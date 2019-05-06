using ProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class ProblemPrinter
    {
        public static void PrintAllProblems(int start, int end, Type objectType)
        {
            for (int i = 1; i <= 25; i++)
            {
                PrintProblem(i, objectType);
            }
        }

        public static void PrintProblem(int problemNumber, Type objectType)
        {
            var method = objectType.GetMethod($"Problem{problemNumber}");

            if (method != null)
            {
                method.Invoke(null, null);

                // ToDo: Add a pause here, something like "Press enter to continue"...
            }
            else
                Console.WriteLine($"Unable to find Problem {problemNumber}...");
        }
    }
}
