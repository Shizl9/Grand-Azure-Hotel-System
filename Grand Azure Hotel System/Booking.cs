using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Booking
    {
        private static int nextBookingID;
        private int bookingID;
        private Guest ? guest;
        private Rooms ? room;
        public int BookingID
        {
            get { return bookingID; }
        }
        public Guest ?Guest
        {
            get { return guest; }
        }
        public Rooms ?Room
        {
            get { return room; }
        }
        public Booking (Guest guest, Rooms room) 
        {
           this.guest = guest;
           this.room = room;
           bookingID = nextBookingID++;
        }

        public void DisplayBookingInfo()
            {
                Console.WriteLine("Booking ID: " + bookingID);
                Console.WriteLine("Guest Name: " + guest?.FullName);
                Console.WriteLine("Room Number: " + room?.RoomNumper);
                Console.WriteLine("Room Type: " + room?.RoomType);
            }
    }
}
