﻿using System;

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
                    Problems_1_To_25.PrintAllProblems();
                }
                else if (userChoice > 0)
                {
                    if (userChoice <= 25)
                        Problems_1_To_25.PrintProblem(userChoice);
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