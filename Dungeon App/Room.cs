using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Room
    {
        //fields
        private Dictionary<int, Room> battleRooms;
        private string roomName;
        bool isLocked;
        private int randomRoom;
        private int roomID;
        private string roomDescription;

        //properties
        public Dictionary<int, Room> BattleRooms
        {
            get { return battleRooms; }
            set { battleRooms = value; }
        }
        public string RoomDescription
        {
            get { return roomDescription; }
            set { roomDescription = value; }
        }
        public int RandomRoom
        {
            get { return randomRoom; }
            set { randomRoom = value; }
        }
        public string[,] Rooms { get; set; }
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public bool IsLocked
        {
            get { return isLocked; }
            set { isLocked = value; }
        }

    }
}
