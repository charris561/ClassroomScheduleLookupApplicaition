using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Schedule_Lookup_UI
{
    public partial class GUI : Form
    {
        List<Course> courseList;
        Facility facility;
        ScheduleReader reader;

        public GUI()
        {
            reader = new ScheduleReader();
            courseList = new List<Course>();
            courseList = reader.ReadCourses();
            facility = new Facility(courseList);
            InitializeComponent();
            InitializeHomePage();
            InitializeGlobalSearchPage();
            InitializeSingleSearchPage();
        }

        private string GetTimeUntilMeeting(DateTime dateTime, Course course) 
        {
            string timeUntilClass = "-";

            if (course.StartDate < dateTime && course.EndDate > dateTime)
            {
                if (course.WeekDays.Contains(dateTime.DayOfWeek))
                {
                    if (course.MeetingStartTime.TimeOfDay > dateTime.TimeOfDay && dateTime.TimeOfDay < course.MeetingEndTime.TimeOfDay)
                    {
                        timeUntilClass = (course.MeetingStartTime.TimeOfDay - dateTime.TimeOfDay).ToString().Remove(5) + " HH:MM";
                    }
                }
            }

            return timeUntilClass;
        }

        private void InitializeBuildingDashboard()
        {
            //set number of available classrooms for each building in dashboard
            List<Label> buildingsDashboard = new List<Label>();
            buildingsDashboard.Add(coluCountLabel);
            buildingsDashboard.Add(centCountLabel);
            buildingsDashboard.Add(dwirCountLabel);
            buildingsDashboard.Add(engrCountLabel);
            buildingsDashboard.Add(ocseCountLabel);
            buildingsDashboard.Add(laneCountLabel);
            buildingsDashboard.Add(uhalCountLabel);
            buildingsDashboard.Add(cuchCountLabel);
            buildingsDashboard.Add(brecCountLabel);
            buildingsDashboard.Add(acadCountLabel);

            foreach (Label blgLabel in buildingsDashboard) 
            {
                foreach (Building building in facility.Buildings)
                { 
                    if (blgLabel.Name.ToUpper().Contains(building.Name))
                    {
                        //assign number of available classrooms to label
                        blgLabel.Text = $"{building.GetNumAvailableRooms()}";
                    }
                }
            }

            buildingsDashboardGroupBox.Text = $"Buildings Dashboard - Rooms Available on {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void InitializeHomePage()
        {
            InitializeBuildingDashboard();
            uccsLogoBox.Image = new Bitmap(Properties.Resources.UCCSLogo);
            globalSearchPanel.SendToBack();
            globalSearchDataGridView.Visible = false;
            globalSearchPanel.Visible = false;
            singleClassroomSearchPanel.SendToBack();singleClassroomSearchPanel.Visible = false;
        }

        private void InitializeGlobalSearchPage()
        {
            globalSearchTimePicker.ShowUpDown = true;
        }

        private void InitializeSingleSearchPage()
        { 
            notificationLabel.Visible = false;
            noClassScheduledOnDateTimeNotificationLabel.Visible = false;
            roomDisplayTitleLabel.Visible = false;
            singleSearchTimePicker.ShowUpDown = true;
        }

        //Events

        private void globalSearchBtn_Click(object sender, EventArgs e)
        {
            globalSearchPanel.Visible = true;
            globalSearchPanel.BringToFront();
            homePagePanel.SendToBack();
        }

        private void singleClassroomSearchBtn_Click(object sender, EventArgs e)
        {
            singleClassroomSearchPanel.Visible = true;
            singleClassroomSearchPanel.BringToFront();
            homePagePanel.SendToBack();
        }

        private void globalSearchSearchBtn_Click(object sender, EventArgs e)
        {
            globalSearchDataGridView.DataSource = null;
            globalSearchDataGridView.Columns.Clear();
            globalSearchDataGridView.Rows.Clear();
            globalSearchDataGridView.Visible = true;
            DateTime globalSearchDateTime = globalSearchDatePicker.Value.Date + globalSearchTimePicker.Value.TimeOfDay;
            List<Room> availableRooms = reader.RoomsAvailableAtTime(globalSearchDateTime, courseList, facility);

            //get next meeting times
            List<string> nextMeetingTimes = new List<string>();
            List<string> timesUntilNextMeeting = new List<string>();
            foreach (Room room in availableRooms) 
            {
                string returnVal = room.GetNextClassTime(globalSearchDateTime);
                string nextMeetingStartTime;
                string timeUntilNextMeeting = room.GetTimeUntilNextClass(globalSearchDateTime);
                if (timeUntilNextMeeting.Length > 1) { timeUntilNextMeeting =  timeUntilNextMeeting.Remove(5) + " HH:MM"; }
                if (returnVal != "No more classes scheduled today!") 
                { 
                    nextMeetingStartTime = DateTime.Parse(returnVal).ToShortTimeString(); 
                }
                else { nextMeetingStartTime = returnVal; }
                nextMeetingTimes.Add(nextMeetingStartTime);
                timesUntilNextMeeting.Add(timeUntilNextMeeting);
            }

            globalSearchDataGridView.DataSource = availableRooms;
            globalSearchDataGridView.Columns[1].Visible = false;
            globalSearchDataGridView.Columns.Add("nextMeetingStartTime", "Next Meeting Time");
            globalSearchDataGridView.Columns.Add("timeUntilNextMeeting", "Time Until Next Meeting");

            //add next meetimg times to display
            for (int i = 0; i < globalSearchDataGridView.Rows.Count; i++) 
            {
                globalSearchDataGridView.Rows[i].Cells[2].Value = nextMeetingTimes[i];

                //get time until next meeting from specified 
                globalSearchDataGridView.Rows[i].Cells[3].Value = timesUntilNextMeeting[i];
            }

            globalSearchDataGridView.Columns[2].Width = 200;
        }

        private void globalSearchBackBtn_Click(object sender, EventArgs e)
        {
            homePagePanel.BringToFront();
            globalSearchPanel.SendToBack();
            globalSearchPanel.Visible = false;
            globalSearchDataGridView.Visible = false;
        }

        private void singleSearchBackButton_Click(object sender, EventArgs e)
        {
            homePagePanel.BringToFront();
            singleClassroomSearchPanel.SendToBack();
            singleClassroomSearchPanel.Visible = false;
        }

        private void singleClassroomSearchSearchButton_Click(object sender, EventArgs e)
        {
            //reset datagridview
            singleClassroomSearchDataGridView.DataSource = null;
            singleClassroomSearchDataGridView.Columns.Clear();
            singleClassroomSearchDataGridView.Rows.Clear();

            //get text entered into textbox
            string roomEntered = roomPromptTextBox.Text;
            roomEntered = roomEntered.ToUpper();
            roomEntered = roomEntered.Replace(" ", "");
            if (roomEntered.Contains("DWTN")) { roomEntered.Replace("DWTN", "DT"); }

            //validate room entered
            bool validRoom = false;
            Room room = null;
            for (int i = 0; i < facility.Rooms.Count && !validRoom; i++) 
            {
                if (facility.Rooms[i].ShortDescription.Replace(" ", "").Contains(roomEntered))
                {
                    validRoom = true;
                    notificationLabel.Visible = false;
                    room = facility.Rooms[i];
                }
            }

            if (roomEntered == "") { validRoom= false; }

            if (!validRoom) 
            {
                notificationLabel.Visible = true;
                notificationLabel.Text = "Invalid room entered! Please try again.";
            }

            //if valid room, display it
            if (validRoom)
            {
                roomDisplayTitleLabel.Visible = true;

                //fetch class schedule data
                DateTime singleSearchDateTime = singleSearchDatePicker.Value.Date + singleSearchTimePicker.Value.TimeOfDay;
                List<Course> coursesInRoom = reader.RoomScheduleOnDate(singleSearchDateTime, roomEntered, courseList);

                //notify user if no classes in room today
                if (coursesInRoom.Count == 0)
                {
                    noClassScheduledOnDateTimeNotificationLabel.Visible = true;
                    noClassScheduledOnDateTimeNotificationLabel.Text = "No classes scheduled in the room!";
                }
                else { noClassScheduledOnDateTimeNotificationLabel.Visible = false; }

                //notify user if classroom is in use at specified time
                if (room.IsRoomInUse(singleSearchDateTime))
                {
                    classScheduledOnDateTimeNotificationLabel.Text = "Room is in use at specified time!";
                    classScheduledOnDateTimeNotificationLabel.Visible = true;
                }
                else { classScheduledOnDateTimeNotificationLabel.Visible = false; }
                    
                roomDisplayTitleLabel.Text = $"Displaying: {roomEntered} | {coursesInRoom.Count} Classes in Room";

                //set grid datasource with specified columns using linq query
                var dataSource = coursesInRoom.Select(o => new { Room = o.ShortDescription, Start_Date = o.StartDate, 
                    End_Date = o.EndDate, Start_Time = o.MeetingStartTime.ToShortTimeString(), End_Time = o.MeetingEndTime.ToShortTimeString(), 
                Time_Until_Meeting = GetTimeUntilMeeting(singleSearchDateTime, o)}).ToList();
                singleClassroomSearchDataGridView.DataSource = dataSource;
                singleClassroomSearchDataGridView.Columns[5].Width = 125;
            }
        }

        //check if enter pressed on texbox
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (roomPromptTextBox.Focused)
                {
                    singleClassroomSearchSearchButton_Click(sender, e);
                }
            }
        }

        //display all valid rooms in pop up window
        private void singleSearchDisplayAcceptableRooms_Click(object sender, EventArgs e)
        {
            string message = "";
            string title = "Valid Rooms";
            int i = 1;
            foreach (Room room in facility.Rooms)
            {
                if (i == 1) { message = message + room.ShortDescription; }
                else if (i == 4) { message = message +" | " + room.ShortDescription + "\n"; i = 0; }
                else { message = message + " | " + room.ShortDescription; }
                i++;
            }
            MessageBox.Show(message, title);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message =
                @"Author: Caleb Harris
Title: IT Professional
Company: UCCS OIT Services
Date Published: 2/2/2023
-----
Description: This application will allow users to query classroom schedule data to more efficiently resolve audio visual issues in supported classrooms.
";
            string title = "About";
            MessageBox.Show(message, title);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://kb.uccs.edu/display/SD/Classroom+Schedule+Lookup+Application");
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://forms.office.com/Pages/ResponsePage.aspx?id=-kOTUsjon0GrLqcMEAOIEPh9rRaqcrFMtcM6mHbU4qZUOUhXSFpCNkdLUVZEWjJKNUcwSU9VOExFMi4u");
        }
    }
}
