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
            string exitResp;
            //END DECLARING VARIABLES  

            Console.WriteLine("Want to play a game? YES/NO");
            exitResp = Console.ReadLine().ToLower();

            while (exitResp == "no")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }


            while (exitResp == "yes")
            {


                //JACKPOT VALUE
                Console.WriteLine("The lottery jackpot is currently at $" + jackpot + "!");
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
                int[] guessArray = new int[6];
                for (int i = 0; i < guessArray.Length; i++)
                {
                    Console.WriteLine("Enter any number between " + (startNum) + " and " + (endNum) + " !");
                    userGuess = int.Parse(Console.ReadLine());

                    if (guessArray.Contains(userGuess))//CHECKING FOR DUPLICATE ENTRIES
                    {
                        Console.WriteLine("Oops! Looks like you entered the same number twice. Please enter a different number.");

                    }//END CHECKING FOR DUPLICATE ENTRIES
                    while ((userGuess < startNum || userGuess > endNum))//VALIDATE THAT NUMBER INPUT IS WITHIN RANGE WHILE LOOP
                    {
                        Console.WriteLine("Oops! The number you entered is outside of the range you chose. Please try again.");
                        userGuess = (int.Parse(Console.ReadLine()));//END VALIDATE THAT NUMBER INPUT IS WITHIN RANGE

                        //if (guessArray.Contains(userGuess))
                        //{ Console.WriteLine("Oops! Looks like you entered the same number twice. Please enter a different number.");
                            
                        //}
                        
                        break;
                    }
                    guessArray[i] = userGuess;//ARRAY
                }
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
                for (int i = 0; i < guessArray.Length; i++)
                {
                    for (int j = 0; j < randNum.Length; j++)
                        if (guessArray[i] == randNum[j])
                        {
                            count += 1;
                            break;
                        }
                }
                Console.WriteLine("You guessed " + count + " numbers correctly!");
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
                } //END CALCULATE WINNINGS

                //PLAY AGAIN
                Console.WriteLine("Play Again? YES/NO");
                exitResp = Console.ReadLine().ToLower();


                while (exitResp == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }


                while (exitResp == "yes")
                {


                    break;

                }
            }
        }//CLOSE MAIN METHOD
    }
}


    
    
    


