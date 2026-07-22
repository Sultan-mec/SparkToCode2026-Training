using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal class Guest
    {
        public string guestId { get; set; }
        public string guestName { get; set; }
        public string roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }
        public Guest(string GuestId, string GuestName, string CheckInDate, int TotalNights)
        {
            guestId = GuestId;
            guestName = GuestName;
            roomNumber = "Not Assigned";
            checkInDate = CheckInDate;
            totalNights = TotalNights;
        }
        public double CalculateTotalCost(double pricePerNight)
        {
            return totalNights * pricePerNight;
        }

        public void displayGuest()
        {
            Console.WriteLine($"ID: {guestId} | Name: {guestName} | Room: {roomNumber} | Check-in: {checkInDate} | Nights: {totalNights}");
        }
    }
}
