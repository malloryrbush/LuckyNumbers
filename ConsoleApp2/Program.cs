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
            int jackpot = (600);

            //END DECLARING VARIABLES 

            //JACKPOT VALUE
            Console.WriteLine("Wanna retire early? The lottery jackpot is currently at $" + jackpot + "!");
            //END JACKPOT VALUE 

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

                while ((userGuess < startNum || userGuess > endNum))//VALIDATE THAT NUMBER INPUT IS WITHIN RANGE WHILE LOOP
                {
                    Console.WriteLine("Oops! The number you entered is outside of the range you chose. Please try again.");
                    userGuess = (int.Parse(Console.ReadLine()));//END VALIDATE THAT NUMBER INPUT IS WITHIN RANGE
                }//END WHILE LOOP
                guessNums[i] = userGuess;//ARRAY
            }//END FOR LOOP
             //END USER INPUT 6 GUESSES FOR LOOP

            //RANDOM NUMBER GENERATOR
            int[] randNum = new int[6];//ARRAY

            //RANDOM NUMBER GENERATOR
            Random r = new Random();
            int count = (0);
            for (int j = 0; j < randNum.Length; j++)
            {
                randNum[j] = r.Next(startNum, endNum);
                Console.WriteLine("Lucky Number: " + randNum[j]);
            }//END RANDOM NUMBER GENERATOR

            //COMPARING LIKE NUMBERS
            for (int i=0; i<guessNums.Length; i++)
            {
                for (int j=0; j<randNum.Length; j++)
                    if (guessNums[i] == randNum[j])
                    {
                        count+= 1;
                        break;
                    }
            } Console.WriteLine("You guessed " + count + " numbers correctly!");
            //END COMPARING LIKE NUMBERS.

            //CALCULATE WINNINGS
            switch (count)
            {
                case 0:
                    Console.WriteLine("You won $" + (jackpot * 0) + ".");
                    break;

                case 1:
                    Console.WriteLine("You won $" + (jackpot / 6) + ".");
                    break;

                case 2:
                    Console.WriteLine("You won $" + (jackpot / 5) + ".");
                    break;

                case 3:
                    Console.WriteLine("You won $" + (jackpot / 4) + ".");
                    break;

                case 4:
                    Console.WriteLine("You won $" + (jackpot / 3) + ".");
                    break;

                case 5:
                    Console.WriteLine("You won $" + (jackpot / 2) + ".");
                    break;

                case 6:
                    Console.WriteLine("You won $" + (jackpot) + ".");
                    break;
            }








        } //CLOSE MAIN METHOD
    }
}
    
    
    


