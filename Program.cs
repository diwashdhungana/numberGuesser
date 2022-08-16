using System;

namespace NumberGuesser
{
    class Number
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int winningNum = randomNum.Next(0,100);
            bool win = false;

            do 
            {
                Console.WriteLine("Guess a number between 0 and 100");
                var choosenNum = Console.ReadLine();

                int i = int.Parse(choosenNum);

                if (i > winningNum)
                {
                    Console.WriteLine("High!!! choose low number ");
                }

                else if (i < winningNum)
                {
                    Console.WriteLine("Low!!! choose higher number");
                }

                else if (i == winningNum)
                {
                    Console.WriteLine("you choose the right number");
                    Console.ReadLine();
                    win = true ;

                }

            }while (win == false);
        }
    }
}
