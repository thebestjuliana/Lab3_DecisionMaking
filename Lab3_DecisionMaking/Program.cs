using System;

namespace Lab3_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            bool playing = true;

            Console.WriteLine("Welcome to the Decision maker, What's your name?");
            userName = Console.ReadLine();

            while (playing)
            {
                
                bool validEntry = false;
                string userEntry = "";
                
                int userInteger = 0;


                while (validEntry == false)
                {
                    Console.WriteLine($"{userName}, Enter a number between 1 and 100:");
                    userEntry = Console.ReadLine();
                    validEntry = ValidityTest(userEntry);
                    
                }
                userInteger = int.Parse(userEntry);

                //added the <= 60 because the last if statement ensures that all odd numbers above 60 have this code run twice

                if (OddTest(userInteger) && userInteger <= 60)
                {
                    Console.WriteLine($"{userInteger} Odd");
                }
                if (OddTest(userInteger) == false && userInteger >= 2 && userInteger < +25)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                if (OddTest(userInteger) == false && userInteger >= 26 && userInteger <= 60)
                {
                    Console.WriteLine("Even.");
                }
                if (OddTest(userInteger) && userInteger > 60)
                {
                    Console.WriteLine($"{userInteger} Odd");
                }
                bool question = true;
                while (question == true) 
                {
                    Console.WriteLine($"{userName} Play again? y/n");
                    string answerToPlaying = Console.ReadLine().ToLower();

                    if (answerToPlaying == "n")
                    {
                        Console.WriteLine($"{userName}, Thanks for playing! Goodbye!");
                        question = false;
                        playing = false;
                    } else if (answerToPlaying == "y")
                    {
                        Console.WriteLine("yay");
                        question = false;
                    } else
                    {
                        Console.Beep();
                        Console.WriteLine("invalid answer");

                    }
                }


            }
        }
        public static bool ValidityTest(string userEntry)
        {
            int number; 
            bool success = Int32.TryParse(userEntry, out number) ;
            if (success)
                {
                int userInteger = int.Parse(userEntry);
                if (userInteger > 100 || userInteger < 1)
                {
                    Console.WriteLine("Invalid Entry, Please Try Again");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Entry, Please Try again");
                return false; 
            }

        }
        public static bool OddTest(int userInteger)
        {
            if(userInteger % 2 > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
            
    }
}
