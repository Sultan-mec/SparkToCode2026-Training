namespace Project_Sprint2
{
    internal class Program
    {

        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

















        //main
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            Console.WriteLine("===== New User Account Creation =====");
            Console.WriteLine("Enter Your Name: ");
            string Name = Console.ReadLine().Trim();
            Console.WriteLine("Enter your account number: ");
            string AcNum = Console.ReadLine().Trim();
            //
            if (accountNumbers.Contains(AcNum))
            {
                Console.WriteLine("Error: Account number exists..");
                return;
            }
            double initialDeposit = 0;
            try
            {
                Console.WriteLine("Enter initial deposit amount: ");
                initialDeposit = double.Parse(Console.ReadLine());
                if (initialDeposit <= 0)
                {
                    Console.WriteLine("Ammout must not be negative");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("initail ammout must be a valid number");
                return;
            }
            //
            customerNames.Add(Name);
            accountNumbers.Add(AcNum);
            balances.Add(initialDeposit);
            //
            Console.WriteLine("Review your info below: ");
            Console.WriteLine($"Account name: {Name}");
            Console.WriteLine($"Account number: {AcNum}");
            Console.WriteLine($"Current balance: {initialDeposit}");

        }
        static void DepositMoney()
        {
            Console.WriteLine("Enter account number to deposit: ");
            string accountNumber = Console.ReadLine().Trim();
            //
            int index = 0;

            if (accountNumbers.Contains(accountNumber))
            {
                index = accountNumbers.IndexOf(accountNumber);
            }
            else
            {
                Console.WriteLine("Account number not found..");
                return;
            }
            //
            try
            {
                Console.WriteLine("Enter deposit ammout");
                double ammount = double.Parse(Console.ReadLine().Trim());
                if (ammount <= 0)
                {
                    Console.WriteLine("amount invalid..");
                    return;
                }
                else
                {
                    balances[index] += ammount;
                    Console.WriteLine($"Current balance: {balances[index]}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("amount invalid..");
                return;
            }
        }
        static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number to withdraw: ");
            string accountNumber = Console.ReadLine().Trim();
            //
            int index = 0;

            if (accountNumbers.Contains(accountNumber))
            {
                index = accountNumbers.IndexOf(accountNumber);
            }
            else
            {
                Console.WriteLine("Account number not found..");
                return;
            }
            //
            try
            {
                Console.WriteLine("Enter desired withdraw ammout: ");
                double ammount = double.Parse(Console.ReadLine().Trim());
                if (ammount <= 0)
                {
                    Console.WriteLine("amount invalid..");
                    return;
                }
                if (ammount > balances[index])
                {
                    Console.WriteLine("Amount exceeds available funds");
                    return;
                }
                else
                {
                    balances[index] -= ammount;
                    Console.WriteLine($"Current available funds: {balances[index]}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("amount invalid..");
                return;
            }
        }
        static void ShowBalance()
        {
            Console.WriteLine("Enter account number to show balance: ");
            string accountNumber = Console.ReadLine().Trim();
            //
            int index = 0;

            if (accountNumbers.Contains(accountNumber))
            {
                index = accountNumbers.IndexOf(accountNumber);
            }
            else
            {
                Console.WriteLine("Account number not found..");
                return;
            }
            Console.WriteLine($"Account name: {customerNames[index]}");
            Console.WriteLine($"Account number: {accountNumbers[index]}");
            Console.WriteLine($"Current balance: {balances[index]}");
        }
        static void TransferAmount()
        {
            Console.WriteLine("Enter account number of Sneder: ");
            int index1 = 0;
            string accountNumber = Console.ReadLine().Trim();


            if (accountNumbers.Contains(accountNumber))
            {
                index1 = accountNumbers.IndexOf(accountNumber);
            }
            else
            {
                Console.WriteLine("Account number not found..");
                return;
            }
            Console.WriteLine("Enter account number of Receiver: ");
            int index2 = 0;
            string accountNumber2 = Console.ReadLine().Trim();


            if (accountNumbers.Contains(accountNumber2))
            {
                index2 = accountNumbers.IndexOf(accountNumber2);
            }
            else
            {
                Console.WriteLine("Account number not found..");
                return;
            }
            //
            if (index1 == index2)
            {
                Console.WriteLine("Account numbers can not match..");
                return;
            }
            //
            Console.WriteLine("enter transfer amount");
            double transferAmount = 0;
            //
            try
            {
                transferAmount = double.Parse(Console.ReadLine().Trim());
                if (transferAmount <= 0)
                {
                    Console.WriteLine("ammount invalid..");
                    return;
                }
                if (transferAmount > balances[index1])
                {
                    Console.WriteLine("Amount exceeds available funds");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid transfer amount number");
                return;
            }
            //
            balances[index1] -= transferAmount;
            balances[index2] += transferAmount;
            //
            Console.WriteLine("Transaction compleated successfully");
            Console.WriteLine($"Sender: '{accountNumber}' current new balance: {balances[index1]}");
            Console.WriteLine($"Receiver: '{accountNumber2}' current new balance: {balances[index2]} ");
        }



        //
    }
}