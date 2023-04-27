using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Schedule_Lookup_UI
{
    /// <summary>
    /// This class will read class schedule data from data source and query that data. 
    /// </summary>
    public class ScheduleReader
    {
        /// <summary>
        /// This function returns a list of all courses read in from flat file. 
        /// In the future, data source may be changed to database.
        /// </summary>
        /// <returns></returns>
        public List<Course> ReadCourses()
        {
            List<Course> courseList = new List<Course>();

            try
            {
                StreamReader reader = new StreamReader(Constants.InputFile);
                reader.ReadLine(); //skip headers
                
                //read course data
                while (!reader.EndOfStream)  
                {
                    Course course = new Course();
                    course.WeekDays = new List<DayOfWeek>();
                    String[] courseData = reader.ReadLine().Split(',');
                    course.Building = courseData[0].Remove(0, 2);
                    course.Room = courseData[1];
                    course.Description = courseData[2]; ;
                    if (courseData[3][0] == 'C') { course.ShortDescription = courseData[3].Remove(0, 1).Trim('_').Replace(" ", ""); }
                    else { course.ShortDescription = courseData[3].Trim('_').Replace(" ", ""); }
                    course.Term = courseData[4];

                    //convert date/time to applicable format (hh:mm:ss) and handle PM vs AM
                    course.MeetingStartTime = DateTime.Parse(courseData[5].Remove(0, 12).Replace('.', ':').Remove(5));
                    course.MeetingEndTime = DateTime.Parse(courseData[6].Remove(0, 12).Replace('.', ':').Remove(5));
                    DateTime noon = DateTime.Parse("12:00");
                    TimeSpan ts_noon = noon.TimeOfDay;
                    if (courseData[5].Contains("PM"))
                    {
                        TimeSpan startTime = course.MeetingStartTime.TimeOfDay;
                        if (TimeSpan.Compare(startTime, ts_noon) == -1)
                        {
                            course.MeetingStartTime = course.MeetingStartTime.AddHours(12);
                        }
                    }
                    if (courseData[6].Contains("PM"))
                    {
                        TimeSpan endTime = course.MeetingEndTime.TimeOfDay;
                        if (TimeSpan.Compare(endTime, ts_noon) == -1)
                        {
                            course.MeetingEndTime = course.MeetingEndTime.AddHours(12);
                        }
                    }

                    bool[] weekdays = new bool[7];
                    int k = 0;
                    for (int j = 7; j < 14; j++)
                    {
                        switch (courseData[j])
                        {
                            case "Y":
                                weekdays[k] = true;
                                course.WeekDays.Add(Constants.ExistingWeekdays[k]);
                                break;
                            case "N":
                                weekdays[k] = false;
                                break;
                            default:
                                weekdays[k] = false;
                                break;
                        }
                        k++;
                    }
                    course.WeekDaysSchedule = weekdays;

                    //remove unecessary time from end of strings
                    course.StartDate = DateTime.Parse(courseData[14].Trim(new char[] { '0', ':' }));
                    course.EndDate = DateTime.Parse(courseData[15].Trim(new char[] { '0', ':' }));

                    courseList.Add(course);
                }

            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
            }

            return courseList;

        }

        /// <summary>
        /// Returns a list of courses on given singular date/time from couresList
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="courseList"></param>
        public List<Room> RoomsAvailableAtTime(DateTime dateTime, List<Course> courseList, Facility facility)
        {
            List<Room> availableRooms = new List<Room>();
            var roomsNotInUse = from room in facility.Rooms
                                where room.IsRoomInUse(dateTime) == false
                                select room;

            foreach (var room in roomsNotInUse) { availableRooms.Add(room); }

            return availableRooms;
        }

        /// <summary>
        /// This function returns a list of courses for an inputted short description
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="courseList"></param>
        /// <returns></returns>
        public List<Course> RoomScheduleOnDate(DateTime dateTime, string shortDescription, List<Course> courseList) 
        {
            List<Course> coursesInRoom = new List<Course>();

            var courses = from course in courseList
                          where course.WeekDays.Contains(dateTime.DayOfWeek)
                          where course.ShortDescription.ToUpper() == shortDescription.ToUpper()
                          where course.StartDate < dateTime && course.EndDate > dateTime
                          orderby course.MeetingStartTime
                          select course; 

            foreach (var course in courses) 
            {
                coursesInRoom.Add(course);
            }

            return coursesInRoom;
        }
    }
}