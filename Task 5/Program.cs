namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Choose a task:");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
           
            
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
        int[] grades = new int[5];
        for (int i = 0; i < grades.Length; i++ ) 
        {
            Console.WriteLine("Enter grade for student " + (i+1) + ": ");
            grades [i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("grades entered in array:");
        foreach (int i in grades )
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }

}

internal class Task2
{
    public static void Run()
    {
        List<string> toDoList = new List<string>();
        //
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter task " + (i + 1) + ": ");
            string task = Console.ReadLine();
            toDoList.Add(task);
        }
        //
        Console.WriteLine("your to do list:");
        int number = 1;
        foreach (string task in toDoList)
        {
            Console.WriteLine(number + task);
            number++;
        }
        Console.ReadLine();
    }

}

internal class Task5
{
    public static void Run()
    {
        int[] grades = new int[5];
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine("Enter grade for student " + (i + 1) + ": ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        //
        Array.Sort(grades);
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / 5;
        Console.WriteLine("lowest grade" + grades[0]);
        Console.WriteLine("average grade" + average);
        Console.WriteLine("highest grade" + grades[grades.Length - 1]);
        Console.ReadLine();
    }

}

internal class Task6
{
    public static void Run()
    {
        List<string> ShoppingList = new List<string>();



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
