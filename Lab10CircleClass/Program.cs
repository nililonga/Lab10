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
        public static bool True { get; private set; }

        static void Main(string[] args)
        {
            do
            {
                float Value;
                string Answer;

                Console.Write($"enter the {radius}:  ");
                Value = (Convert.ToInt32(Console.ReadLine()));
                int int.MaxValue = Convert.ToInt32(Value);
                //bool ValidRadius = Regex.IsMatch(Value, "\\d{1,5000}.\\d{1,5000}");
                //Console.WriteLine(ValidRadius);

                if ()
                {
                    //call class

                }
                else
                {
                    Console.WriteLine("That was not a valid entry");
                }

                //prompt user to continue
                Console.WriteLine("Would you like to continue? (Y/N)");
                Answer = (Console.ReadLine());

                string Answer;
                while (Answer == "Y") ;
            }
        }
        
    }
}
