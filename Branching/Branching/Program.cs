using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 23 ? " you have an awsome favorite number!" : "You do not have an awsome favorite number!";
            Console.WriteLine(result);
            Console.ReadLine();

            //int roomTemp = 70;

            //Console.WriteLine("Hi what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong.......");
            //}

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp";
            //Console.WriteLine(comparisonResult);

            //if (currentTemperature == roomTemperature) 
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature) 
            //{
            //    Console.WriteLine("It is warmer than room temperature. ");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temp.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp. ");
            //}
            //Console.ReadLine();
        }
    }
}
