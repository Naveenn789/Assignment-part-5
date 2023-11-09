using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBasicPart5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your score as a percentage");
            int X = int.Parse(Console.ReadLine());
            if(X >= 90)
            {
                Console.WriteLine("you got Grade " + 'A' + " "+X);
            }
            else if (X >= 80 && X<=89)
            {
                Console.WriteLine("you got Grade " + 'B' + " " + X);
            }
            else if (X >= 70 && X <= 79)
            {
                Console.WriteLine("you got Grade " + 'C' + " " + X);
            }
            else if (X >= 60 && X <= 69)
            {
                Console.WriteLine("you got Grade " + 'D' + " " + X);
            }
            else
            {
                Console.WriteLine("You got Grade "+'F' + " " + X);
            }
            Console.ReadKey();

        }
    }
}
