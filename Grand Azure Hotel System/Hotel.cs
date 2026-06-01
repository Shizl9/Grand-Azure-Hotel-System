using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Hotel
    {
        private List<Guest> ?guests;
        private List<Rooms> ?rooms;
        private List<Booking>? bookings;
        public string ? HotelName { get;}
        public Hotel (string name)
        {
            HotelName = name;
        }
        public void AddGuest(string name, string id) { 
            if (guests == null)
            {
                guests = new List<Guest>();
            }
            Guest newGuest = new Guest(name, id);
            guests.Add(newGuest);
        }
        public Guest FindGuest(string nationalID)
        {
            var res = guests?.FirstOrDefault(g => g.NationalID == nationalID);
          foreach(var guest in guests)
            {
                if (guest.NationalID == nationalID)
                {
                    return guest;
                }
            }
            return null;
        }
        }
    }
}
