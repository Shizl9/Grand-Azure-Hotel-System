using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Rooms
    {
        private int roomNumber;
        private string? roomType;
        private bool isBooked;
        public int RoomNumper
        {
            get
            {
                return roomNumber;
            }
        }
        public string? RoomType
        {
            get { return roomType; }
        }
        public bool IsBooked
        {
            get { return isBooked; }
        }
        public Rooms(int number, string type)
        {
            roomNumber = number;
            roomType = type;
            isBooked = false;
        }
        public bool Book()
        {
           
        }
        public void CancelBooking()
        {
            
        }
        public void DisplayRoomInfo()
        {
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Is Booked: " + isBooked);
        }
        
    }
}
