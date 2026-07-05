namespace Task_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a task:");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("3. Task 3");
            Console.WriteLine("4. Task 4");
            Console.WriteLine("5. Task 5");
            Console.WriteLine("6. Task 6");
            Console.WriteLine("7. Task 7");
            Console.WriteLine("8. Task 8");
            Console.WriteLine("9. Task 9");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("=================Task 1 selected================");
                    Task1.Run();
                    break;
                case "2":
                    Console.WriteLine("=================Task 2 selected================");
                    Task2.Run();
                    break;
                case "3":
                    Console.WriteLine("=================Task 3 selected================");
                    Task3.Run();
                    break;
                case "4":
                    Console.WriteLine("=================Task 4 selected================");
                    Task4.Run();
                    break;
                case "5":
                    Console.WriteLine("=================Task 5 selected================");
                    Task5.Run();
                    break;
                case "6":
                    Console.WriteLine("=================Task 6 selected================");
                    Task6.Run();
                    break;
                case "7":
                    Console.WriteLine("=================Task 7 selected================");
                    Task7.Run();
                    break;
                case "8":
                    Console.WriteLine("=================Task 8 selected================");
                    Task8.Run();
                    break;
                case "9":
                    Console.WriteLine("=================Task 9 selected================");
                    Task9.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}





internal class Task1
{
    public static void Run()
    {
        int counter = 0;
        int userinput = 0;
        //
        Console.WriteLine("enter a number to countdown Liftoff!");
        userinput = int.Parse(Console.ReadLine());
        //
        for (int i = userinput; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }

}

internal class Task2
{
    public static void Run()
    {
        int sum = 0;
        //
        Console.WriteLine("enter a positive whole number, to get the calculate the sum from 1");
        int userinput2 = int.Parse(Console.ReadLine());
        //
        for (int i = 1; i <= userinput2; i++)
        {
            sum += i;
        }
        //
        Console.WriteLine("sum from 1 to " + userinput2 + " is: " + sum);

    }
}

internal class Task3
{
    public static void Run()
    {
        Console.WriteLine("enter a number to get its multiplication table");
        int userinput3 = int.Parse(Console.ReadLine());
        //
        for (int i = 1; i <= 10; i++)
        {
            int result = userinput3 * i;
            Console.WriteLine(userinput3 + " x " + i + " = " + result);
        }
    }
}

internal class Task4
{
    public static void Run()
    {
        Console.WriteLine("what's the password?");
        string password = "Spark2026";
        bool correctPassword = false;
        //
        while (!correctPassword)
        {
            string userInput = Console.ReadLine();
            if (userInput == password)
            {
                correctPassword = true;
                Console.WriteLine("Access granted.");
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}

internal class Task5
{
    public static void Run()
    {
        int secretN = 42;
        int CounterGuess = 1;
        bool correctGuess = false;
        //
        do
        {
            Console.WriteLine("Guess the secret number (between 1 and 50):");
            int userGuess = int.Parse(Console.ReadLine());
            if (userGuess > secretN)
            {
                Console.WriteLine("too high, Try again.");
                CounterGuess++;
            }
            else if (userGuess < secretN)
            {
                Console.WriteLine("too low, Try again.");
                CounterGuess++;
            }
            else
            {
                correctGuess = true;
                Console.WriteLine("You guessed the secret number in " + CounterGuess + " attempts.");

            }
        }
        while (!correctGuess);
    }

}

internal class Task6
{
    public static void Run()
    {
        try
        {
            Console.WriteLine("enter 2 numbers to divide them. what is the first number?");
            int userinput4 = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the second number?");
            int userinput5 = int.Parse(Console.ReadLine());

            double divisionResult = (double)(userinput4 / userinput5);
            Console.WriteLine("The result of dividing " + userinput4 + " by " + userinput5 + " is: " + divisionResult);
        }
        //
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid number.");
        }
        //
    }

}


internal class Task7
{
    public static void Run()
    {
        bool mainmenu = true;
        //while loop for main menu
        while (mainmenu)
        {
            //try catch block to handle invalid input
            try
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show current Time-of-Day");
                Console.WriteLine("3. Exit");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                //switch statement to handle user choice
                {
                    case 1:
                        Console.WriteLine("Hello");
                        break;
                    case 2:
                        Console.WriteLine("GOOD MYTHICAL MORNING!");
                        break;
                    case 3:
                        mainmenu = false;
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break; // <- required to avoid CS8070
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }

    }
}
internal class Task8
{
    public static void Run()
    {
        Console.WriteLine("Enter a positive whole number. Get the sum of only even numbers from 1 to N(userinput)");

        int userinput6 = 0;
        int sum2 = 0;


        while (true)
        {
            try
            {
                userinput6 = int.Parse(Console.ReadLine());

                if (userinput6 < 1)
                {
                    Console.WriteLine("Invalid input. Please enter a positive whole number.");
                }
                else if (userinput6 % 2 != 0)
                {
                    Console.WriteLine("Invalid input. Please enter an even number.");
                }
                else
                {
                    break; // Valid input: positive and even
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Calculate sum
        for (int i = 1; i <= userinput6; i++)
        {
            if (i % 2 == 0)
            {
                sum2 += i;
            }
        }

        // Print result
        Console.WriteLine("The sum of even numbers from 1 to " + userinput6 + " is: " + sum2);
    }
}




internal class Task9
{
    public static void Run()
    {


    }

}