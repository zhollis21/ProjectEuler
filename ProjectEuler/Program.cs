using ProjectEuler.Problems;
using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\tWelcome to my repository for solving Project Euler Problems.");

            while (true)
            {
                int userChoice = GetUserSelection();

                if (userChoice == 0)
                {
                    ProblemPrinter.PrintAllProblems(1, 25, typeof(Problems_001_To_025));
                    ProblemPrinter.PrintAllProblems(26, 50, typeof(Problems_026_To_050));
                    ProblemPrinter.PrintAllProblems(51, 75, typeof(Problems_051_To_075));
                    ProblemPrinter.PrintAllProblems(76, 100, typeof(Problems_076_To_100));
                }
                else if (userChoice > 0)
                {
                    if (userChoice <= 25)
                        ProblemPrinter.PrintProblem(userChoice, typeof(Problems_001_To_025));

                    else if (userChoice <= 50)
                        ProblemPrinter.PrintProblem(userChoice, typeof(Problems_026_To_050));

                    else if (userChoice <= 75)
                        ProblemPrinter.PrintProblem(userChoice, typeof(Problems_051_To_075));

                    else if (userChoice <= 100)
                        ProblemPrinter.PrintProblem(userChoice, typeof(Problems_076_To_100));

                    else
                        Console.WriteLine($"Unable to find Problem {userChoice}...");
                }
                else
                {
                    return;
                }
            }
        }

        static int GetUserSelection()
        {
            PrintMenu();

            while (true)
            {
                string userInput = Console.ReadLine().ToLower();

                char userChoice = userInput.Length > 0 ? userInput[0] : '?';

                if (userChoice == 'a')
                {
                    return 0;
                }
                else if (userChoice == 's')
                {
                    Console.Write("Enter the problem number: ");

                    try
                    {
                        int problemNumber = Convert.ToInt32(Console.ReadLine());

                        if (problemNumber > 0)
                            return problemNumber;
                    }
                    catch
                    {
                        // We let this go through and print the invalid choice at the bottom of the loop
                    }
                }
                else if (userChoice == 'q')
                {
                    return -1;
                }
                
                Console.WriteLine("Invalid choice, please try again...\n");
                PrintMenu();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("\n\nWhat would you like to do?\n" +
                              "\n\t'A': Print the solution to all problems" +
                              "\n\t'S': Print the solution to a specific problem" +
                              "\n\t'Q': Quit");
        }
    }
}