using ShapeAreaLib;
using System;


namespace ShapeAreaConAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, result;
            string choice;
            do
            {
                ShapeArea sh = new ShapeArea();
                Console.WriteLine("Choose operation \n1. Area of Rectangle \n2.Area of Sqaure. \n3.Area of Circle \n4. Area of Triangle");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Height of Rectangle: ");
                            double h = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Breadth of Rectangle: ");
                            double b = double.Parse(Console.ReadLine());
                            result = sh.AreaRect(h, b);
                            Console.WriteLine($"Area of Rectangle is {result}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the side of Square: ");
                            double s = double.Parse(Console.ReadLine());
                            result = sh.AreaSq(s);
                            Console.WriteLine($"Area of Sqaure is {result}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the radius of Circle: ");
                            double r = double.Parse(Console.ReadLine());
                            result = sh.AreaCircle(r);
                            Console.WriteLine($"Area of Rectangle is {result}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the Height of Triangle: ");
                            double h = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Base of Triangle: ");
                            double b = double.Parse(Console.ReadLine());
                            result = sh.AreaTri(h, b);
                            Console.WriteLine($"Area of Triangle is {result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong choice entered.");
                            break;
                        }
                }
                Console.WriteLine("Press y to continue");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
            Console.ReadKey();
        }
    }
}
