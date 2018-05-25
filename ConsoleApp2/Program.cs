using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARING VARIABLES
            int startNum;
            int endNum;
            int guess;
            //END DECLARING VARIABLES 

            //WRITELINE LOWEST RANGE NUMBER INPUT
            Console.WriteLine("Please choose the lowest number you would like in your guessing range.");
            startNum = int.Parse(Console.ReadLine());
            //END WRITELINE LOWEST RANGE NUMBER INPUT

            //WRITELINE HIGHEST RANGE NUMBER INPUT
            Console.WriteLine("Please choose the highest number you would like in your guessing range.");
            endNum = int.Parse(Console.ReadLine());
            //END WRITELINE HIGHEST RANGE NUMBER INPUT

            //WRITELINE ASK FOR 6 NUMBERS
            Console.WriteLine("Enter any number between " + (startNum) + " and " + (endNum) + " !");
            guess = int.Parse(Console.ReadLine());
            //END WRITELINE ASK FOR 6 NUMBERS
        }
    }
}
