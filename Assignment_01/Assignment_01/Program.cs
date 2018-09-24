using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle Rectangle = new Rectangle();
            int userSelection = 0;
            //int enterLength;
            EnterValue(Rectangle);

            do
            {
                Console.WriteLine("Please enter one of the following options:");
                Console.WriteLine("1. Get Rectangle Side Length");
                Console.WriteLine("2. Change Rectangle Side Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Set Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit\n");

                try
                {

                    userSelection = int.Parse(Console.ReadLine());

                    if (userSelection == 1)
                    {
                        Console.WriteLine("\nThe lengths of the Rectangle are {0}\n", Rectangle.Getlength());
                    }

                    else if (userSelection == 2)
                    {
                        Rectangle.Setlength(changeLength());
                        Rectangle.Getlength();
                    }

                    else if (userSelection == 3)
                    {
                        Console.WriteLine("\nThe Width of the Rectangle are {0}\n", Rectangle.GetWidth());
                    }

                    else if (userSelection == 4)
                    {
                        
                        Rectangle.SetWidth(changeWidth());
                        
                        Rectangle.GetWidth();
                    }

                    else if (userSelection == 5)
                    {
                        Console.WriteLine("\nThe perimeter of the Rectangle is {0}\n", Rectangle.GetPerimeter());
                    }

                    else if (userSelection == 6)
                    {
                        Console.WriteLine("\nThe area of the Rectangle is {0}\n", Rectangle.GetArea());
                    }

                    else if (userSelection == 7)
                    {
                        Console.WriteLine("\nExiting program......");
                    }

                    else
                    {
                        Console.WriteLine("\nPlease make a selection between 1-7\n");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nInvalid option. Please make another selection.\n");
                    userSelection = int.Parse(Console.ReadLine());
                }
            } while (userSelection != 7);
        }


        private static void EnterValue(Rectangle rectangle)
        {
            int enterLength, enterwidth;
            do
            {
                Console.WriteLine("\nPlease enter Length of Rectangle.\n");
            }
            while (!int.TryParse(Console.ReadLine(), out enterLength) || enterLength <= 0);

            do
            {
                Console.WriteLine("\nPlease enter Width of Rectangle.\n");
            }
            while (!int.TryParse(Console.ReadLine(), out enterwidth) || enterwidth <= 0);
            rectangle.Setlength(enterLength);
            rectangle.SetWidth(enterwidth);

            //1. Length, width input.
            //2. validate inputs
            //3. rectangle create using inputs (length, width).
            //4. SHow 7 options
        }

        private static int changeLength()
        {
            int enterLength;
            do
            {
                Console.WriteLine("\nPlease enter new Length of Rectangle.\n");
            }
            while (!int.TryParse(Console.ReadLine(), out enterLength) || enterLength <= 0);
            return enterLength;
        }

        private static int changeWidth()
        {
            int enterWidth;
            do
            {
                Console.WriteLine("\nPlease enter new width of Rectangle.\n");
            }
            while (!int.TryParse(Console.ReadLine(), out enterWidth) || enterWidth <= 0);
            return enterWidth;
        }
    }
}
