using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10CircleClass
{
    class Program 
    {
        private static string input2;

        public static bool True { get; private set; }

        static void Main(string[] args)
        {
            do
            {
                double radius;
                Console.WriteLine("please enter a radius: ");
                string input = (Console.ReadLine());
                bool true1 = double.TryParse(input, out radius);
                while (!true1) //while loop to validate input was a number
                {
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine("please enter a radius: ");
                    input = Console.ReadLine();
                    true1 = double.TryParse(input, out radius);
                }
                   //create circle object 
                //convert input to double
                radius = Convert.ToDouble(input);
                Circle circle1 = new Circle(input);
                {
                    //calculate area and circumference of circle
                    //Console.WriteLine($"The area of the circle is{circle1.CalculateFormattedArea}");
                    Console.WriteLine($"The circumference of the circle is {circle1.Radius}");

                    Console.WriteLine("would you like to continue? y/n");
                    input2 = Console.ReadLine().ToUpper();
                }
            } while (input2 == "y");


        }
            
        }
        
    
}
