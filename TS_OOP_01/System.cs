

using HotelSystem;

namespace TS_OOP_01
{
    internal class System
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();
        static int GuestCounter = 0;
        static void Main(string[] args)
        {
            PreloadRooms();
            bool is_running = true;
            while (is_running)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("=== GRAND VISTA HOTEL — MANAGEMENT SYSTEM ===");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.Write("\nEnter your choice: ");
                int option;
                try { option = int.Parse(Console.ReadLine() ?? ""); }
                catch (FormatException) { Console.WriteLine("Invalid option."); continue; }
                switch (option)
                {
                    case 0: is_running = false; break;
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookRoom(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: Search0FilterRoom(); break;
                    case 7: GuestBookingStatistics(); break;
                    case 8: UpdateRoomPrice(); break;
                    case 9: GuestLookup(); break;
                    case 10: RoomTypeReport(); break;
                        // case 11: CheckOut(); break;
                        // case 12: RemoveUnavailableRooms(); break;
                        // case 13: ExtendGuestStay(); break;
                        // case 14: HighestRevenueBooking(); break;
                        // case 15: GuestPaginationViewer(); break;


                }
                Console.WriteLine("press any key.");
                Console.ReadKey();
                Console.Clear();


            }
        }

        static void PreloadRooms()
        {
            rooms.Add(new Room(101, "Single", 21.00));
            rooms.Add(new Room(107, "Single", 20.00));
            rooms.Add(new Room(402, "Double", 39.00));
            rooms.Add(new Room(306, "Double", 44.00));
            rooms.Add(new Room(505, "Suite", 50.00));
            rooms.Add(new Room(501, "Suite", 55.00));
        }
        static void AddNewRoom()
        {
            Console.WriteLine("Enter Room number of your desire: ");
            int Roomnum;
            try { Roomnum = int.Parse(Console.ReadLine() ?? ""); } catch (FormatException) { Console.WriteLine("Invalid number."); return; }
            //
            if (rooms.Any(r => r.roomNumber == Roomnum))
            { Console.WriteLine("Room exists.. try another number"); return; }
            //
            Console.WriteLine("choose the type(Single, Double, Suite): ");
            string RoomType = Console.ReadLine() ?? "";
            if (RoomType != "Single" && RoomType != "Double" && RoomType != "Suite")
            { Console.WriteLine("invalid room type"); return; }
            //
            Console.WriteLine("Enter room price per night: ");
            double Price;
            try { Price = double.Parse(Console.ReadLine() ?? ""); } catch (FormatException) { Console.WriteLine("Invalid price."); return; }
            //
            rooms.Add(new Room(Roomnum, RoomType, Price));
            Console.WriteLine("data procceseed and entered into system");
            Console.WriteLine($"Room number: {Roomnum}");
            Console.WriteLine($"Room type: {RoomType} ");
            Console.WriteLine($"Price per night: {Price}");
            Console.WriteLine($"Total rooms currently: {rooms.Count}");
        }
        static void RegisterNewGuest()
        {

            Console.Write("enter the guest name: ");
            string name = Console.ReadLine() ?? "";
            //
            Console.Write("enter guest check-in date (dd/MM/yyyy): ");
            string date = Console.ReadLine() ?? "";
            //
            Console.Write("Enter how many nights the guest will stay at the hotel: ");
            int nights;
            try { nights = int.Parse(Console.ReadLine() ?? ""); }
            catch (FormatException) { Console.WriteLine("Invalid number.."); return; }
            //
            if (nights < 0) { Console.WriteLine("Number of nights cannot be a negative"); return; }
            string guestID = "G" + GuestCounter.ToString("c1");
            GuestCounter++;
            //
            guests.Add(new Guest(guestID, name, date, nights));
            //
            Console.WriteLine("Guest has been registered (Procced to book a room next)");
            Console.WriteLine($"Guest ID:{guestID}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Check-in Date: {date}");
            Console.WriteLine($"Nights: {nights}");
            Console.WriteLine("Room Assigned: Not Assigned");
            Console.WriteLine($"Total Guests:{guests.Count}");

        }
        //recheck//
        static void BookRoom()
        {
            Console.Write("Please enter guest ID: ");
            string guestid = (Console.ReadLine() ?? "").ToUpper();

            var Guest0 = guests.FirstOrDefault(g => g.guestId == guestid);
            if (Guest0 != null)
            {
                Console.WriteLine(Guest0.guestId);
            }
            else
            {
                Console.WriteLine("guest not found.");
                return;
            }
            //
            Console.Write("Please enter Room number: ");
            int roomNum;
            try { roomNum = int.Parse(Console.ReadLine() ?? ""); }
            catch (FormatException) { Console.WriteLine("Invalid number."); return; }
            //
            var RoomPick = rooms.FirstOrDefault(r => r.roomNumber == roomNum);
            if (RoomPick != null)
            {
                if (RoomPick.isAvailable)
                {
                    Console.WriteLine("Room is found and available!");
                }
                else
                {
                    Console.WriteLine("Room is already booked.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Room not found.");
                return;
            }
            //
            Guest0.roomNumber = RoomPick.roomNumber.ToString();
            RoomPick.isAvailable = false;
            double totalCost = Guest0.CalculateTotalCost(RoomPick.pricePerNight);
            //
            Console.WriteLine($"Room has been booked for {Guest0.guestName}");
            Console.WriteLine($"Guest Name: {Guest0.guestName}");
            Console.WriteLine($"Room Number: {RoomPick.roomNumber}");
            Console.WriteLine($"Room Type: {RoomPick.roomType}");
            Console.WriteLine($"Price Per Night: {RoomPick.pricePerNight}");
            Console.WriteLine($"Total Nights: {Guest0.totalNights}");
            Console.WriteLine($"Total Cost: {totalCost} OMR");

        }
        static void ViewAllRooms()
        {

            int count = rooms.Count;
            Console.WriteLine($"Room count: {count}");
            //
            if (count <= 0) { Console.WriteLine("no rooms has been added yet"); }
            var listrooms = rooms.ToList();
            foreach (var room in listrooms)
            { room.displayRoom(); }
        }
        //recheck^^
        static void ViewAllGuests()
        {
            int count = guests.Count;
            Console.WriteLine($"Guest count has reached {count}!!!!");
            if (count <= 0)
            {
                Console.WriteLine("uhm..the list is empty");
                var listguests = guests.ToList();
                foreach (var guest in listguests)
                { guest.displayGuest(); }
            }
        }
        //
        static void Search0FilterRoom()
        {
            while (true)
            {
                Console.WriteLine("(1) Show all available rooms");
                Console.WriteLine("(2) Filter by room type");
                Console.WriteLine("(3) Filter by max price");
                Console.WriteLine("(4) Room price statistics");
                Console.WriteLine("(0) Back");
                Console.Write("Enter your choice: ");

                int option;
                try { option = int.Parse(Console.ReadLine() ?? ""); }
                catch (FormatException) { Console.WriteLine("Invalid option."); Console.ReadKey(); continue; }

                switch (option)
                {
                    case 0: return;
                        //
                    case 1:
                        var found = rooms.Where(r => r.isAvailable).OrderBy(r => r.pricePerNight).ToList();
                        Console.WriteLine($"Available Rooms Count: {found.Count}");
                        if (found.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        foreach (var room in found)
                        {
                            room.displayRoom();
                        }
                        break;
                        //
                    case 2:
                        Console.Write("Please enter room type(Single / Double / Suite): ");
                        string type = Console.ReadLine() ?? "";
                        if (type != "Single" && type != "Double" && type != "Suite")
                        { Console.WriteLine("Wrong Room Type."); break; }

                        var found2 = rooms.Where(r => r.roomType == type).ToList();
                        Console.WriteLine($"Available Rooms Count: {found2.Count}");
                        //
                        if (found2.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        foreach (var room2 in found2)
                        {
                            room2.displayRoom();
                        }
                        break;
                        //
                    case 3:
                        Console.Write("Please enter max price: ");
                        double price;
                        try { price = double.Parse(Console.ReadLine() ?? ""); } catch (Exception) { Console.WriteLine("Wrong number"); break; }
                        var found3 = rooms.Where(r => r.pricePerNight <= price).OrderBy(r => r.pricePerNight).ToList();
                        Console.WriteLine($"Available Rooms Count: {found3.Count}");

                        if (found3.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        foreach (var room3 in found3)
                        {
                            room3.displayRoom();
                        }
                        break;
                        //
                    case 4:
                        int totalRooms = rooms.Count();
                        int availableRooms = rooms.Count(r => r.isAvailable);
                        if (totalRooms == 0) { Console.WriteLine("No rooms in the system to calculate statistics."); break; }
                        double averagePrice = rooms.Average(r => r.pricePerNight);
                        double minPrice = rooms.Min(r => r.pricePerNight);
                        double maxPrice = rooms.Max(r => r.pricePerNight);

                        Console.WriteLine($"Total Rooms:       {totalRooms}");
                        Console.WriteLine($"Available Rooms:   {availableRooms}");
                        Console.WriteLine($"Average Price:     {averagePrice:F2} OMR");
                        Console.WriteLine($"Cheapest Price:    {minPrice:F2} OMR");
                        Console.WriteLine($"Most Expensive:    {maxPrice:F2} OMR");
                        break;

                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }
                Console.WriteLine("press any key.");
                Console.ReadKey();
                Console.Clear();
            }


        }
        static void GuestBookingStatistics()
        {
            int countGuests = guests.Count();
            int assignedGuests = guests.Count(g => g.roomNumber != "Not Assigned");
            Console.WriteLine($"Total Registered Guests:   {countGuests}");
            Console.WriteLine($"Guests with Rooms:         {assignedGuests}");
            int totalRooms = rooms.Count();
            int bookedRooms = rooms.Count(r => !r.isAvailable);

            Console.WriteLine($"Total Rooms:     {totalRooms}");
            Console.WriteLine($"Booked Rooms:    {bookedRooms}");

            var guestsWithBookings = guests.Where(g => g.roomNumber != "Not Assigned");
            if (guestsWithBookings.Any())
            {
                double averageNights = guestsWithBookings.Average(g => g.totalNights);
                Console.WriteLine($"Average Nights: {averageNights:F2} nights");
            }
            else
            {
                Console.WriteLine("Average Nights: 0.0 nights (No active bookings)");
            }



            var topguests = guests.Where(g => g.roomNumber != "Not Assigned").OrderByDescending(g =>
            {
                var room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == g.roomNumber);
                double price = room != null ? room.pricePerNight : 0;
                return g.CalculateTotalCost(price);
            }).Take(3).ToList();

            if (topguests.Count == 0)
            {
                Console.WriteLine("No active bookings found to calculate spending.");
            }
            else
            {
                int rank = 1;
                foreach (var guests in topguests)
                {
                    var room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == guests.roomNumber);
                    double price = room != null ? room.pricePerNight : 0;
                    double totalCost = guests.CalculateTotalCost(price);
                    Console.WriteLine($"{rank}. Guest:       {guests.guestName}");
                    Console.WriteLine($"   Room Number: {guests.roomNumber}");
                    Console.WriteLine($"   Total Cost:  {totalCost:F2} OMR");
                    rank++;
                }
            }

            var guestsWithBookings2 = guests.Where(g => g.roomNumber != "Not Assigned")
                .Select(g =>
                {
                    var room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == g.roomNumber);
                    double price = room != null ? room.pricePerNight : 0;
                    double totalCost = g.CalculateTotalCost(price);

                    return $"{g.guestName} — Room {g.roomNumber} — {g.totalNights} nights — OMR {totalCost:F2}";
                }).ToList();
            if (guestsWithBookings2.Count == 0)
            {
                Console.WriteLine("No active bookings recorded.");
            }
            else
            {
                foreach (var guest in guestsWithBookings2)
                {
                    Console.WriteLine(guest);
                }
            }

        }
        static void UpdateRoomPrice()
        {
            Console.Write("Enter Room Number: ");
            int num; try { num = int.Parse(Console.ReadLine() ?? ""); } catch (FormatException) { Console.WriteLine("Wrong Input."); return; }
            var roomm = rooms.FirstOrDefault(r => r.roomNumber == num);
            if (roomm == null) { Console.WriteLine("Room not Found."); return; }
            double oldPrice = roomm.pricePerNight;
            Console.WriteLine("Enter new Room/Night price: ");
            double newPrice; try { newPrice = double.Parse(Console.ReadLine() ?? ""); } catch (FormatException) { Console.WriteLine("Wrong Input."); return; }
            if (newPrice <= 0) { Console.WriteLine("Room Price Must be positive number."); return; }
            roomm.pricePerNight = newPrice;
            Console.WriteLine($"Room Number: {roomm.roomNumber}");
            Console.WriteLine($"Old Price/Night: OMR {oldPrice:F2}");
            Console.WriteLine($"New Price/Night: OMR {newPrice:F2}");
        }
        static void GuestLookup()
        {
            Console.Write("Enter guest name or partial name to search: ");
            string name = Console.ReadLine() ?? "";
            var lookup = guests.Where(g => g.guestName.ToLower().Contains(name.ToLower())).ToList();
            if (lookup.Count == 0)
            {
                Console.WriteLine("No guests matched that search.");
            }
            else
            {
                Console.WriteLine($"Matches Found: {lookup.Count}");


                foreach (var guest in lookup)
                {
                    Console.WriteLine($"ID: {guest.guestId}");
                    Console.WriteLine($"Name: {guest.guestName}");
                    Console.WriteLine($"Room Number: {guest.roomNumber}");
                }
            }

        }
        static void RoomTypeReport()
        {
            var single = rooms.Where(r => r.roomType == "Single");
            var singleCount = single.Count();
            var Doubleroom = rooms.Where(r => r.roomType == "Double");
            var doubleCount = Doubleroom.Count();
            var Suite = rooms.Where(r => r.roomType == "Suite");
            var SuiteCount = Suite.Count();
            string singleAvg = singleCount > 0
                ? $"OMR {single.Average(r => r.pricePerNight):F2}"
                : "N/A";

            string doubleAvg = doubleCount > 0
                ? $"OMR {Doubleroom.Average(r => r.pricePerNight):F2}"
                : "N/A";

            string suiteAvg = SuiteCount > 0
                ? $"OMR {Suite.Average(r => r.pricePerNight):F2}"
                : "N/A";
            double overallAverage = rooms.Any() ? rooms.Average(r => r.pricePerNight) : 0;

            Console.WriteLine("Report!!");
            Console.WriteLine("Room Type : Count , Average Price/Night");
            Console.WriteLine($"Single : {singleCount,-6} , {singleAvg}");
            Console.WriteLine($"Double : {doubleCount,-6} , {doubleAvg}");
            Console.WriteLine($"Suite  : {SuiteCount,-6} , {suiteAvg}");
            Console.WriteLine($"Overall Average Room Price: OMR {overallAverage:F2}");
        }

        /////////////end of road/////////
    }
}
