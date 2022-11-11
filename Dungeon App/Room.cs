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
        private int gauntletRoomCompleted;
        private int gauntletRoomID;
        private bool exitRoom;

        //properties
        public bool ExitRoom
        {
            get { return exitRoom; }
            set { exitRoom = value; }
        }
        public int GauntletRoomID
        {
            get { return gauntletRoomID; }
            set { gauntletRoomID = value;}
        }
        public int GauntletRoomCompleted
        {
            get { return gauntletRoomCompleted; }
            set { gauntletRoomCompleted = value;}
        }
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
