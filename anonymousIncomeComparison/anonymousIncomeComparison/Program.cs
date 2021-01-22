using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comarison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1 \n Hourly rate?");
            int person1rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2 \n Hourly rate?");
            int person2rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int year = 52;
            int person2hours = Convert.ToInt32(Console.ReadLine());
            int salary1 = person1rate * person1hours * year; 
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            int salary2 = person2rate * person2hours * year;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Dose Person 1 make more money than Person 2?");
            bool isBigger = salary1 > salary2;
            Console.WriteLine(isBigger);
            Console.ReadLine();

        }
    }
}
