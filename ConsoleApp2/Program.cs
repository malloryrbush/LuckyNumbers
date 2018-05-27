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
            
            //bool Contains;
            //string matches;
            //END DECLARING VARIABLES 

            //JACKPOT VALUE
            Console.WriteLine("Wanna retire early? The lottery jackpot is currently at $5,125,000!");
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
            int[] randNum = new int[6];

            Random r = new Random();
            int count = (0);
            for (int j = 0; j < randNum.Length; j++)
            {
                randNum[j] = r.Next(startNum, endNum);
                Console.WriteLine("Lucky Number: " + randNum[j]);
            }//END FOR LOOP
            
            for (int i=0; i<guessNums.Length; i++)
            {
                for (int j=0; j<randNum.Length; j++)
                    if (guessNums[i] == randNum[j])
                    {
                        count+= 1;
                    }
            } Console.WriteLine("You guessed " + count + " right!");

        } //CLOSE MAIN METHOD
    }
}
    
    
    


