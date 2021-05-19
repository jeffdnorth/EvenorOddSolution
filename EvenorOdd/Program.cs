using System;

namespace EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            var runAgain = true;
            while (runAgain == true)
            {


                Console.Write("Enter an integer: ");
                var answerStr = Console.ReadLine();
                var answer = int.Parse(answerStr);
                var evenNumber = answer % 2 == 0;
                if (evenNumber == true)
                {
                    Console.WriteLine($"{answer} is even.");
                }

                else
                {


                    Console.WriteLine($"{answer} is odd.");
                }
                Console.Write("Want to run again?  (Y if yes)  :  ");
                answerStr = Console.ReadLine();
                if (answerStr == "y" || answerStr == "Y")
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }

            }

        }
    }
}