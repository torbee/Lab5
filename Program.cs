using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("How many sides should each die have? ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Roll: ");
                Console.WriteLine(GetRoll(i));
                Console.WriteLine(GetRoll(i));
            }
            run = Continue();
        }
        public static int GetRoll(int i)
        {
            Random rng = new Random();
            int d = (rng.Next(1, i++));
            return d;
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Roll again? (y/n): ");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y") {
                run = true;
            }
            else if (answer == "n" || answer == "N")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Input not valid. Please try again.");
                run = Continue();
            }
            return run;
        }
    }
}
