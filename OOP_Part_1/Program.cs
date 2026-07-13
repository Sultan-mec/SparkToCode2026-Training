using OOP_Part_1;

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
        public void Deposit(double amount)
        {
            if (amount > 0) { Console.WriteLine("invalid amount.."); }
            else { Balance += amount; SendEmail(); }
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds..");
            }
            else
            {

                Balance -= amount;
                SendEmail();
            }
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
        private void SendEmail()
        {
            Console.WriteLine("Email will arrive shortly..");
        }
    }
    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email;
        int age;
        //
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Email sent.");
        }
    }
}
public class Product
{

    public string ProductName { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }
    
    public void Sell(int quantity)
    {
        if (quantity > StockQuantity)
        {
            Console.WriteLine("not enough stock");
        }
        else
        {
            StockQuantity -= quantity;

        }
        LogTransaction();
    }

    public void Restock(int quantity)
    {
        if (quantity < 0)
        {
            Console.WriteLine("Invalid amount.");
        }
        else
        {
            StockQuantity += quantity;
            LogTransaction();
        }
    }
    public double GetInventoryValue()
    {
        PrintDetails();
        return Price * StockQuantity;
    }
    private void PrintDetails()
    {
        Console.WriteLine("==============================");
        Console.WriteLine($"Product name: {ProductName}");
        Console.WriteLine($"Product Price: {Price}");
        Console.WriteLine($"StockQuantity : {StockQuantity}");
        Console.WriteLine("==============================");
    }
    private void LogTransaction()
    {
        Console.WriteLine("LogTransaction");
    }
}

///////////////////////////////////////////////////////////////



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

    //main
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
                case 2: UpdateStudentAddress(); break;
                case 3: MakeDeposit(); break;
                case 4: MakeWithdrawal(); break;
                case 5: ViewProductDetails(); break;
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
    //main helpers
    static BankAccount ChooseAccount()
    {
        Console.WriteLine("choose account (1 or 2)");
        string input = Console.ReadLine();
        if (input == "2") { return account2; } else { return account1; }
    }
    static Student ChooseStudent ()
    { 
        Console.WriteLine("select a student:" +
        "Type 1 for 'Jalal' or 2 for 'Osama' ");
        //
        int choice;
        try
        {
            choice = int.Parse(Console.ReadLine() ?? "");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input. Please enter a number 1 or 2.");
            return null;
        }
        return (choice == 1) ? student1 : (choice == 2) ? student2 : null;
    }
    //
    static Product ChooseProduct()
    {
        Console.WriteLine("select a product:" +
        "Type 1 for 'Gaming PC' or 2 for 'Coffee Grinder' ");
        //
        int choice;
        try
        {
            choice = int.Parse(Console.ReadLine() ?? "");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input. Please enter a number 1 or 2.");
            return null;
        }
        return (choice == 1) ? product1 : (choice == 2) ? product2 : null;
    }
    static void ViewAccountDetails()
    {

    }
    static void UpdateStudentAddress()
    {

    }
    static void MakeDeposit()
    {

    }
    static void MakeWithdrawal()
    {

    }
    static void ViewProductDetails()
    {

    }
    ///////
}


