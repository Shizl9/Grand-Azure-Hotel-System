using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Guest
    {
        private static int totalGuestsCreated;
        private string ?nationalID
        {
            get { return nationalID; }
        }
        private string ? fullName { get; set; }
        public string ?NationalID 
        { 
            get { return nationalID; }
        }
        public string? FullName { get; set; }
        public Guest(string name,string id)
        {
            FullName = name;
            nationalID= id;
            totalGuestsCreated++;
        }

        public static int GetTotalGuestsCreated()
        {
            return totalGuestsCreated;
        }

        public void DisplayGuestInfo()
        {
            Console.WriteLine("Guest Name: " + FullName);
            Console.WriteLine("National ID: " + nationalID);
        }

    }
}
