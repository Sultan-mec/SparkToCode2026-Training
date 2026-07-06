namespace SparkToCode2026
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
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "4":
                    Task4.Run();
                    break;
                case "5":
                    Task5.Run();
                    break;
                case "6":
                    Task6.Run();
                    break;
                case "7":
                    Task7.Run();
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
        //task 1
        //////////////////////////////////////////
        Console.WriteLine("please enter your name");
        string username1 = Console.ReadLine()!;
        //
        Console.WriteLine("enter your age");
        int userage1 = Convert.ToInt16(Console.ReadLine());
        //
        Console.WriteLine("enter your Hieght");
        double hight1 = double.Parse(Console.ReadLine());
        //


        Console.WriteLine("Are you a student?");
        string studentInput1 = Console.ReadLine()!;
        bool studentcheck1;
        if (studentInput1.ToLower() == "yes")
        {
            studentcheck1 = true;
        }
        else
        {
            studentcheck1 = false;
        }

        Console.WriteLine("Name: " + username1 + " ,Age: " + userage1 + " ,Hieght: " + hight1 + " ,Student: " + studentcheck1);


    }

}

internal class Task2
{
    public static void Run()
    {
        //task 2
        //////////////////////////////////////////
        Console.WriteLine("enter the length of a rectangle and then follow up with the width.");
        int length = Convert.ToInt16(Console.ReadLine());
        int width = Convert.ToInt16(Console.ReadLine());
        int Area = length * width;
        int Perimeter = 2 * (length + width);
        Console.WriteLine("Area: " + Area + " ,Perimeter: " + Perimeter);
    }
}

internal class Task3
{
    public static void Run()
    {
        Console.WriteLine("enter a whole number to check if its even or odd");
        int number0 = Convert.ToInt16(Console.ReadLine());
        float divisioncheck = number0 / 2;
        float remaindercheck = number0 % 2;
        if (remaindercheck == 0)
        {
            Console.WriteLine("the number is even");

        }
        else
        {
            Console.WriteLine("the number is odd");
        }
    }
}

internal class Task4
{
    public static void Run()
    {
        Console.WriteLine("enter your Age");
        int userage2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("do you hold a valid national ID?");
        string validID = (Console.ReadLine());
        bool validIDcheck;
        switch (validID.ToLower())
        {
            case "yes":
                validIDcheck = true;
                break;
            case "no":
                validIDcheck = false;
                break;
            default:
                validIDcheck = false;
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                break;

        }

        if (userage2 >= 18 && validIDcheck)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}

internal class Task5
{
    public static void Run()
    {
        Console.WriteLine("enter a single character of your grade to get the meaning of your grade");
        string grade = Console.ReadLine();

        switch (grade)
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Good");
                break;
            case "C":
                Console.WriteLine("Average");
                break;
            case "D":
                Console.WriteLine("Below Average");
                break;
            case "F":
                Console.WriteLine("Failing");
                break;
            default:
                Console.WriteLine("Invalid grade.");
                break;
        }

    }
}

internal class Task6
{
    public static void Run()
    {
        Console.WriteLine("enter a tempreture in Celsius to convert it to Fahrenheit and classify the weather");
        float celsius = float.Parse(Console.ReadLine());
        float fahrenheit = (celsius * 9 / 5) + 32;


        if (celsius < 10)
        {
            Console.WriteLine("Cold");
        }
        else if (celsius >= 10 && celsius <= 30)
        {
            Console.WriteLine("Mild");
        }
        else if (celsius > 30)
        {
            Console.WriteLine("Hot");
        }
    }
}

internal class Task7
{
    public static void Run()
    {
        Console.WriteLine("enter your age to check your ticket price");
        int userage3 = Convert.ToInt16(Console.ReadLine());

        if (userage3 >= 0 && userage3 <= 12)
        {
            Console.WriteLine("Children: 2.000 OMR");
        }
        else if (userage3 >= 13 && userage3 <= 59)
        {
            Console.WriteLine("Adult: 5.000 OMR");
        }
        else if (userage3 >= 60)
        {
            Console.WriteLine("Seniors: 3.000 OMR");
        }
        else
        {
            Console.WriteLine("Invalid age input.");
        }
    }
}