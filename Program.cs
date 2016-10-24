using System;
using System.Threading;

namespace Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            ProgramInfo();

            // Create randomizer (number)
            Random randomObject = new Random();

            // Loop forever (ask multiple questions)
            while (true)
            {
                string question = GetQuestion();

                if (question.Length == 0)
                {
                    Console.WriteLine("Type a question");
                    // Go back to beginning of while loop
                    continue;
                }

                // See if the user typed quit
                if (question.ToLower() == "quit")
                {
                    // Go out of while loop
                    Console.WriteLine("");
                    break;
                }

                // Generate a random number + 1 for sleep/pause length
                int sleepLength = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking about your answer..stand by");
                Thread.Sleep(sleepLength * 1000);

                // Get random number from 0 to 3
                int randNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor) randomObject.Next(15);

                // Use random number to determine response
                switch (randNumber)
                {
                    case 0:
                        Console.WriteLine("Yes!");
                        break;
                    case 1:
                        Console.WriteLine("Maybe?");
                        break;
                    case 2:
                        Console.WriteLine("No!");
                        break;
                    case 3:
                        Console.WriteLine("Seriously?");
                        break;
                }
            }

            // Cleaning up
            Console.ForegroundColor = oldColor;
        }

        // Program info function
        static void ProgramInfo()
        {
            // Change console color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "Magic 8 Ball";
            Console.WriteLine("Magic 8 Ball by Steven Tomas");
        }

        static string GetQuestion()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            string question = Console.ReadLine();
            return question;
        }
    }
}
