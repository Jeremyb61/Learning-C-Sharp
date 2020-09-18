using System;
using System.Security.Cryptography;


//Namespace
namespace learningCsharp
{
    //Main Class
    class Program
    {
        //Entry Point for Application 
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            while (true)
            {

                //Set correct number
                Random rand = new Random();
                int correctNumber = rand.Next(1, 11);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Please guess a number between 1-10");

                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "String detected, must be a number");
                        continue;
                    }


                    //Cast to int and put into guess var
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }
                //Output Success msg
                string success = "CORRECT! The number was " + correctNumber;
                PrintColorMessage(ConsoleColor.Yellow, success);

                Console.WriteLine("Play again? [Y or N]");

                string inputReplay = Console.ReadLine().ToUpper();

                if(inputReplay == "N")
                {
                    return;
                }
                else if(inputReplay == "Y")
                {
                    continue; ;
                } else
                {
                    return;
                }
                




            }
            static void GetAppInfo ()
            {
                //Set app var
                string appName = "Number Guesser";
                string appVersion = "1.0.0";
                string appAuthor = "Jeremy Billecci";

                //Change Text color
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                //Reset Text Color
                Console.ResetColor();
            }
            static void GreetUser()
            {
                //Ask Users Name
                Console.WriteLine("What is your name?");

                //Get use input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, lets play a game...", inputName);
            }
            static void PrintColorMessage(ConsoleColor color, string message)
            {
                //Change Text color
                Console.ForegroundColor = color;

                //Error message
                Console.WriteLine(message);

                //Reset Text Color
                Console.ResetColor(); 
            }

        }

    }
}
