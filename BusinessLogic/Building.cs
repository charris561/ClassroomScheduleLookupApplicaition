using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule_Lookup_UI
{
    public class Building
    {
        public Building(string name, List<Room> rooms) 
        {
            this.name = name;
            this.rooms = rooms;
        }

        private string name;
        private List<Room> rooms;

        public List<Room> Rooms { get => rooms; set => rooms = value; }
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Returns the number of available classrooms in the building
        /// </summary>
        /// <returns></returns>
        public int GetNumAvailableRooms()
        {
            var courses = from room in rooms
                          where !room.IsRoomInUse(DateTime.Now)
                          select room;

            return courses.Count();
        }
    }
}