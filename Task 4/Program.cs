
namespace Task_4
{
    internal class Program
    {
        public static double CalculateArea(double W, double L)
        {
            return W * L;
        }
        public static double CalculatePerimeter(double W, double L)
        {
            return (2*(W + L));
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(""
        }







    }
}




































//Task 5
/*
namespace Task_4
{
    internal class Program
    {
        public static bool IsEven(int x)
        {
        return x % 2 == 0;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if its even or odd");
            int x = int.Parse(Console.ReadLine());
            bool Answer = IsEven(x);
            if (Answer)
            {
                Console.WriteLine(x + " is an Even Number");
            }
            else
            {
                Console.WriteLine(x + " is an Odd Number");
            }
        }






    }
}

*/




/////Task 9

/*
namespace Task_4
{
    internal class Program
    {
static int Multiply(int a, int b)
{
   return a * b;
}
static double Multiply(double a, double b)
{
   return a * b;
}
static int Multiply(int a, int b, int c)
{
   return a * b * c;
}



static void Main()
{
   Console.WriteLine("program asks for 5 inputs");


   Console.WriteLine("first provide me with 3 integers");
   Console.Write("Enter integer a: ");
   int a = int.Parse(Console.ReadLine());
   Console.Write("Enter integer b: ");
   int b = int.Parse(Console.ReadLine());
   Console.Write("Enter integer c: ");
   int c = int.Parse(Console.ReadLine());


   Console.WriteLine("now provide 2 double values");
   Console.Write("Enter double d: ");
   double d = double.Parse(Console.ReadLine());
   Console.Write("Enter double e: ");
   double e = double.Parse(Console.ReadLine());


   Console.WriteLine("first overload: two integers multiply");
   Console.WriteLine(Multiply(a, b));
   Console.WriteLine("second overload: two doubles multiply");
   Console.WriteLine(Multiply(d, e));
   Console.WriteLine("third overload: 3 integers multiply");
   Console.WriteLine(Multiply(a, b, c));
}
   */








/*    Task 10
 namespace Task_4
{
    internal class Program
    {


        public static double CalculateArea(double x)
        {
            return (x * x);
        }
        public static double CalculateArea(double width, double height)
        {
            return (width * height);
        }
        public static void Main()
        {
            Console.WriteLine("program can give you the area of a Square or a Rectangle!");
            Console.WriteLine("which type would you like to choose?");
            Console.Write("1: Square ");
            Console.WriteLine(" 2. Rectangle");

          

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter side of Square: ");
                    //
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("area of the Square = " + CalculateArea(x));
                    break;
                case "2":
                    Console.Write("Enter width then height of Rectangle: ");
                    //
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("area of the Reqtangle = " + CalculateArea(width, height));
                    break;


            }

        }
    }
}

//
/////////////////////
*/




