using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Math_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be multiplyed by 50");
            long userNumber = Convert.ToInt64(Console.ReadLine());
            long product = userNumber * 50;
            Console.WriteLine(userNumber + " times 50 is: " + product);
            //Console.ReadLine();
            Console.WriteLine("Please enter a new number");
            int newNum = Convert.ToInt32(Console.ReadLine());
            int newTotal = newNum + 25;
            Console.WriteLine("Your new number plus 25 = " + newTotal);
            //Console.ReadLine();
            Console.WriteLine("Please enter a new number");
            int dividedNum = Convert.ToInt32(Console.ReadLine());
            Double dividedNew = dividedNum / 12.5;
            Console.WriteLine("The number you enterd divided by 12.5 is: " + dividedNew);
            //Console.ReadLine();
            Console.WriteLine("Enter a number and ill guess true or false if its bigger than 50");
            int biggerThan = Convert.ToInt32(Console.ReadLine());
            int thisNumber = 50;
            bool isBigger = biggerThan > thisNumber;
            Console.WriteLine(isBigger);
            //Console.ReadLine();
            Console.WriteLine("Please enter a number to be divided by 7 and will print the remainder");
            int diviedNumber = Convert.ToInt32(Console.ReadLine());
            int remainder = dividedNum / 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
