namespace Task_writing_easier_by_sultan
{
    internal class Program
    {
        static void Main(string[] args)
        { //copy from here downwards and paste it in your main program to use this as an extention/feature.
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

            switch (choice)  // after writing a task , you run the program and select task you want to test.
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
        bool isRunning = true;
        while (isRunning)
        {
            try
            {
                //Your task 1 code goes here
                //this helps catch any format exceptions that may occur during input parsing or conversion
                //ensuring that the program doesn't crash and provides a user-friendly error message instead.
                //cc: tankasuar-cloud
                isRunning = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }


        Console.ReadLine();
    }

}

internal class Task2
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task3
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task4
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task5
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task6
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task7
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task8
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task9
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task10
{
    public static void Run()
    {



        Console.ReadLine();
    }

}

internal class Task11
{
    public static void Run()
    {



        Console.ReadLine();
    }

}



/**************************************************************/
internal class Task12
{
    public static void Run()
    {


        //keep empty for fast "copy pasta"

        Console.ReadLine();
    }

}

/**************************************************************/

internal class Task13
{
    public static void Run()
    {

        bool isRunning = true;
        while (isRunning)
        {
            try
            {

                isRunning = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}