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
            int userGuess;
            //END DECLARING VARIABLES 

            //WRITELINE LOWEST RANGE NUMBER INPUT
            Console.WriteLine("Please choose the lowest number you would like in your lottery.");
            startNum = int.Parse(Console.ReadLine());
            //END WRITELINE LOWEST RANGE NUMBER INPUT

            //WRITELINE HIGHEST RANGE NUMBER INPUT
            Console.WriteLine("Please choose the highest number you would like in your lottery.");
            endNum = int.Parse(Console.ReadLine());
            //END WRITELINE HIGHEST RANGE NUMBER INPUT

            //USER INPUT 6 GUESSES FOR LOOP
            int[] guessNums = new int[6];//ARRAY
            for (int i = 0; i < guessNums.Length; i++)
            {
                Console.WriteLine("Enter any number between " + (startNum) + " and " + (endNum) + " !");
                userGuess = int.Parse(Console.ReadLine());
                guessNums[0] = (userGuess);//ARRAY
               
            }
            //END USER INPUT 6 GUESSES FOR LOOP

            //RANDOM NUMBER GENERATOR
            int[] RandNum = new int[6];
            Random r = new Random();
            for (int j = 0; j < RandNum.Length; i++)
            {
                RandNum[j] = r.Next(startNum, endNum + 1);
            }
            //END RANDOM NUMBER GENERATOR




        } //CLOSE MAIN METHOD
    }
}
