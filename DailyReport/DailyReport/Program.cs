using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Welcome: " + yourName + "\n What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            bool needHelp = true;
            string helpStatus = Convert.ToString(needHelp);
            Console.ReadLine();
            Console.WriteLine("Were there any postive experinces youd like to share? Please give specifics.");
            string experincesShare = Console.ReadLine();
            Console.WriteLine("Is there any other feedback youd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
