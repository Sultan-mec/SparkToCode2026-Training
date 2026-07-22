using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal class Room
    {
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; }
        public Room(int RoomNumber, string RoomType, double PricePerNight)
        {
            roomNumber = RoomNumber;
            roomType = RoomType;
            pricePerNight = PricePerNight;
            isAvailable = true;
        }
        public void displayRoom()
        {
            string status = isAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room: {roomNumber} | Type: {roomType}" +
                $" | Price: OMR {pricePerNight} | Status: {status}");

        }
    }
}
