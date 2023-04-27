using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule_Lookup_UI
{
    public class Room
    {
        public Room(List<Course> courses, string shortDescription, string buildingName)
        { 
            this.courseSchedule = courses;
            this.shortDescription = shortDescription;
            this.buildingName = buildingName;
        }

        /// <summary>
        /// Checks whether the room contains a course occuring within date/time window
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public bool IsRoomInUse(DateTime dateTime)
        { 
            bool isRoomInUse = false;

            foreach (Course course in courseSchedule) 
            {
                //check date
                if (course.StartDate < dateTime && course.EndDate > dateTime) 
                {
                    //check week
                    if (course.WeekDays.Contains(dateTime.DayOfWeek))
                    {
                        //check time
                        if (course.MeetingStartTime.TimeOfDay < dateTime.TimeOfDay && course.MeetingEndTime.TimeOfDay > dateTime.TimeOfDay && !isRoomInUse)
                        {
                            isRoomInUse = true;
                        }
                    }
                }
            }

            return isRoomInUse;
        }

        /// <summary>
        /// Returns a string with the time until next class
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public string GetNextClassTime(DateTime dateTime)
        {
            var nextCourse = from course in courseSchedule
                             where course.MeetingStartTime.TimeOfDay > dateTime.TimeOfDay
                             where course.WeekDays.Contains(dateTime.DayOfWeek)
                             orderby course.MeetingStartTime
                             select course;

            string nextCourseTime;
            if (nextCourse.Count() == 0) { nextCourseTime = "No more classes scheduled today!"; }
            else { nextCourseTime = $"{nextCourse.ElementAt(0).MeetingStartTime.TimeOfDay}".Remove(5); }

            return nextCourseTime;
        }

        public string GetTimeUntilNextClass(DateTime dateTime)
        {
            var nextCourse = from course in courseSchedule
                             where course.MeetingStartTime.TimeOfDay > dateTime.TimeOfDay
                             where course.WeekDays.Contains(dateTime.DayOfWeek)
                             orderby course.MeetingStartTime
                             select course;

            string timeUntilNextClass = "";
            if (nextCourse.Count() == 0) { timeUntilNextClass = "-"; }
            else 
            { 
                timeUntilNextClass = (nextCourse.ElementAt(0).MeetingStartTime.TimeOfDay - dateTime.TimeOfDay).ToString();
            }

            return timeUntilNextClass;
        }

        private List<Course> courseSchedule;
        private string shortDescription;
        private string buildingName;

        public List<Course> CourseSchedule { get => courseSchedule; set => courseSchedule = value; }
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public string BuildingName { get => buildingName; set => buildingName = value; }
    }
}