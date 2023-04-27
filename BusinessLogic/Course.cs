using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule_Lookup_UI
{
    public class Course
    {
        private DateTime meetingStartTime;
        private DateTime meetingEndTime;
        private bool[] weekDaysSchedule;
        private List<DayOfWeek> weekDays;
        private DateTime startDate;
        private DateTime endDate;
        private String room;
        private String building;
        private String description;
        private String shortDescription;
        private String term;

        
        public string Room { get => room; set => room = value; }
        public string Building { get => building; set => building = value; }
        public string Description { get => description; set => description = value; }
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public string Term { get => term; set => term = value; }
        public DateTime MeetingStartTime { get => meetingStartTime; set => meetingStartTime = value; }
        public DateTime MeetingEndTime { get => meetingEndTime; set => meetingEndTime = value; }
        public bool[] WeekDaysSchedule { get => weekDaysSchedule; set => weekDaysSchedule = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public List<DayOfWeek> WeekDays { get => weekDays; set => weekDays = value; }

        public override string ToString()
        {
            //format date/time objects into preferrable format
            string startDateString = this.startDate.ToShortDateString();
            string endDateString = this.endDate.ToShortDateString();
            string meetingStartTimeString = this.meetingStartTime.ToShortTimeString();
            string meetingEndTimeString = this.meetingEndTime.ToShortTimeString();

            return $"{shortDescription} | Scheduled From {meetingStartTimeString} to {meetingEndTimeString}";
        }

    }

}