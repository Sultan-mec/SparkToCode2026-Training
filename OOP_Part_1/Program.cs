namespace OOP_Part_1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        public BankAccount(int accountNumber, string name, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = name;
            Balance = balance;
        }
        //
        private void SendEmail()
        {
            Console.WriteLine("Email will arrive shortly..");
        }
        public void Deposit(double amount)
        {
            if (amount > 0) { Console.WriteLine("invalid amount.."); }
            else { Balance += amount; SendEmail(); }
        }
        public double CheckBalance()
        {
            PrintInformation(); return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine($"Name: {HolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
    public class Student
    {

    }
    public class Product
    {

    }
    internal class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 9735, HolderName = "Sultan", Balance = 5950 };
        static BankAccount account2 = new BankAccount { AccountNumber = 1825, HolderName = "Raad", Balance = 6960 };
        //
        static Student student1 = new Student { Name = "Jalal", Address = "Seeb", Grade = 89 };
        static Student student2 = new Student { Name = "Osama", Address = "Ibra", Grade = 79 };
        //
        static Product product1 = new Product { ProductName = "Gaming PC", Price = 800, StockQuantity = 10 };
        static Product product2 = new Product { ProductName = "Coffee Grinder", Price = 30, StockQuantity = 123 };
        //

        ///main
        static void Main(string[] args)
        {
            bool is_running = true;
            while (is_running)
            {
                Console.WriteLine("\n===== Welcome to App =====");
                Console.WriteLine("1. Case 1 - View Account Details");
                Console.WriteLine("2. Case 2 - Update Student Address");
                Console.WriteLine("3. Case 3 - Make a Deposit");
                Console.WriteLine("4. Case 4 - Make a Withdrawal");
                Console.WriteLine("5. Case 5 - View Product Details");
                Console.WriteLine("6. Case 6 - Register a Student");
                Console.WriteLine("7. Case 7 - Compare Two Account Balances");
                Console.WriteLine("8. Case 8 - Restock Product & Stock Level Check");
                Console.WriteLine("9. Case 9 - Transfer Between Accounts");
                Console.WriteLine("10. Case 10 - Update Student Grade");
                Console.WriteLine("11. Case 11 - Student Report Card");
                Console.WriteLine("12. Case 12 - Account Health Status");
                Console.WriteLine("13. Case 13 - Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Case 14 - Scholarship Eligibility Check");
                Console.WriteLine("15. Case 15 - Full Balance Top-Up Flow");
                Console.WriteLine("16. Case 16 - Quick Account Opening [Parameterized Constructor]");
                Console.WriteLine("17. Case 17 - Total Students Counter [Static Fields & Methods]");
                Console.WriteLine("18. Case 18 - Overdrawn Account Check [Read-Only Property]");
                Console.WriteLine("19. Case 19 - Set Student Security PIN [Write-Only Property]");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }
                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    // case 2: UpdateStudentAddress(); break;
                    //case 3: MakeDeposit(); break;
                    //case 4: MakeWithdrawal(); break;
                    //case 5: ViewProductDetails(); break;
                    //case 6: RegisterStudent(); break;
                    //case 7: CompareAccountBalance(); break;
                    //case 8: RestockProduct(); break;
                    //case 9: TransferBetweenAccounts(); break;
                    //case 10: UpdateStudentGrade(); break;
                    //case 11: StudentReportCard(); break;
                    //case 12: AccountHealthStatus(); break;
                    //case 13: BulkSale(); break;
                    //case 14: Scholarship(); break;
                    //case 15: BalanceTopUp(); break;
                    //case 16: QuickAccountOpening(); break;
                    //case 17: DisplayTotalStudents(); break;
                    //case 18: CheckOverdraftStatus(); break;
                    //case 19: SetStudentPin(); break;
                    case 20: is_running = false; break;

                }
                Console.WriteLine("press any key.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static BankAccount ChooseAccount()
        {

        }

        ///////
    }
}

