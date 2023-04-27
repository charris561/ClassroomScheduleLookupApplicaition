using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Schedule_Lookup_UI
{
    public class Facility
    {
        public Facility(List<Course> courseList) 
        {
            //generate courses
            var coursesByRoom = from course in courseList
                                group course by course.ShortDescription into roomGroup
                                orderby roomGroup.Key
                                select roomGroup;

            List<Room> rooms = new List<Room>();
            foreach (var room in coursesByRoom)
            {
                List<Course> roomSchedule = new List<Course>();
                string buildingName = "";
                foreach (var course in room)
                {
                    roomSchedule.Add(course);
                    buildingName = course.Building;
                }
                Room roomObj = new Room(roomSchedule, room.Key, buildingName);
                rooms.Add(roomObj);
            }

            this.rooms = rooms;

            //generate buildings
            var roomsByBlg = from room in rooms
                             group room by room.BuildingName into blgGroup
                             orderby blgGroup.Key
                             select blgGroup;

            List < Building > buildings = new List<Building>();
            foreach (var blg in roomsByBlg)
            {
                List<Room> roomsInBlg = new List<Room>();
                foreach (var room in blg)
                {
                    roomsInBlg.Add(room);
                }
                Building blgObj = new Building(blg.Key, roomsInBlg);
                buildings.Add(blgObj);
            }

            this.buildings = buildings;
        }

        private List<Building> buildings;
        private List<Room> rooms;

        public List<Building> Buildings { get => buildings; set => buildings = value; }
        public List<Room> Rooms { get => rooms; set => rooms = value; }
    }
}