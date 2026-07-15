

namespace TS_OOP_01
{
    internal class System
    {
        List<Room> rooms = new List<Room>();
       // List<Guest> guests = new List<Guest>();

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
                Console.Write("\nEnter your choice: _");
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
                   // case 6: SearchRoom(); break;
                   // case 7: GuestBookingStatistics(); break;
                   // case 8: UpdateRoomPrice(); break;
                    //case 9: GuestLookup(); break;
                    //case 10: RoomTypeReport(); break;
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
            rooms.Add(new Room(101, "single", 21.00));
            rooms.Add(new Room(107, "single", 20.00));
            rooms.Add(new Room(402, "double", 39.00));
            rooms.Add(new Room(306, "double", 44.00));
            rooms.Add(new Room(505, "Suite", 50.00));
            rooms.Add(new Room(501, "Suite", 55.00));
        }
        static void AddNewRoom()
        {

        }
        static void RegisterNewGuest()
        {

        }
        static void BookRoom()
        {

        }
        static void ViewAllRooms()
        {

        }
        static void ViewAllGuests()
        {

        }




































        /////////////end of road/////////
    }
}
