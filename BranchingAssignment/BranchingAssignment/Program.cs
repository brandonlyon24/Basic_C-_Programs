using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int pkWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width: ");
            int pkWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int pkHight = Convert.ToInt32(Console.ReadLine());
        }
    }
}
