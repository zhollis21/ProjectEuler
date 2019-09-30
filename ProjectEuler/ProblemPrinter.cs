using ProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class ProblemPrinter
    {
        public static void PrintAllProblems(int startNumber, int endNumber, Type objectType)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                PrintProblem(i, objectType);
            }
        }

        public static void PrintProblem(int problemNumber, Type objectType)
        {
            string problemNumberWithPadding = problemNumber.ToString().PadLeft(3, '0');
            var method = objectType.GetMethod($"Problem{problemNumberWithPadding}");

            if (method != null)
            {
                DateTime start = DateTime.Now;

                object obj = method.Invoke(null, null);

                if (obj != null && obj is string answer)
                {
                    Console.WriteLine("\n\tAnswer: " + answer);
                }
                else
                {
                    Console.WriteLine("\n\tAn error occurred: The problem didn't return a valid answer.");
                }

                Console.WriteLine($"\nThe problem took {DateTime.Now - start}, press <Enter> to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Unable to find Problem {problemNumber}...");
            }
        }
    }
}
