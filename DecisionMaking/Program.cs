using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            while (isRunning)
            {
               // prompt user for input
                Console.WriteLine("Enter a number 1 and 100 ");
                int userNum;
                // get valid input and int through range 1-100
                while (!int.TryParse(Console.ReadLine(), out userNum) || userNum < 1 || userNum > 100)
                {
                    Console.WriteLine("Sorry {0}, but your input is invalid, please try again",userName);
                }

                // print message depending on given number
                if (userNum%2 == 0)
                {
                    if (userNum > 60)
                    {
                        Console.Write($"{userNum} ");
                    }
                    Console.Write("Even");
                    if (userNum < 25)
                        Console.Write(" and less than 25");
                }
                else
                {
                    Console.WriteLine("{0} Odd",userNum);
                }


                // see if the user wants to run again
                isRunning = GoAgain(userName);
            }
        }

        public static bool GoAgain(string name)
        {
            Console.WriteLine("\nWould you like to go again {0}? (y/n",name);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
                return true;
            else if (input == "n")
            {
                Console.WriteLine("Goodbye {0}", name);
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, please try agian");
                return GoAgain(name);
            }


        }
    }
}
