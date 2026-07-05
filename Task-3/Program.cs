namespace Task_3
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
            Console.WriteLine("9. Task 9"); //you may add more tasks here
            string choice = Console.ReadLine();

            switch (choice)  // after a task , you run the program and select which task you want to test.
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
                    Task9.Run();//you may remove or add more tasks
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}


//code goes here in segments of each task, without the need to "//".

internal class Task1
{
    public static void Run()
    {
        Console.WriteLine("Enter 2 numbers to subtract 2nd from 1st, value should be positive");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int num3 = Math.Abs(num1 - num2);

        Console.WriteLine("The result of the subtraction is: " + num3);
        Console.ReadLine();
        
    }

}

internal class Task2
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to get the power of 2 and Square root");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int power = (int)Math.Pow(num1, 2);
        int squareRoot = (int)Math.Sqrt(num1);

        Console.WriteLine("The power of 2 of " + num1 + " is: " + power);
        Console.WriteLine("The square root of " + num1 + " is: " + squareRoot);

        Console.ReadLine();
    }

}

internal class Task3
{
    public static void Run()
    {

        Console.WriteLine("Enter your fullname to get: letter count, uppercase, and lowercase");
        string fullname = Console.ReadLine();
        Console.WriteLine( fullname.ToUpper() + " " + fullname.ToLower());
        Console.WriteLine( fullname.Length + " letters in your name");

        Console.ReadLine();
    }

}

internal class Task4
{
    public static void Run()
    {




    }

}

internal class Task5
{
    public static void Run()
    {




    }

}

internal class Task6
{
    public static void Run()
    {




    }

}

internal class Task7
{
    public static void Run()
    {




    }

}

internal class Task8
{
    public static void Run()
    {




    }

}

internal class Task9
{
    public static void Run()
    {




    }

}

internal class Task10
{
    public static void Run()
    {




    }

}

internal class Task11
{
    public static void Run()
    {




    }

}


