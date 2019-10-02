using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace ProjectEuler.Problems
{
    public class Problems_051_To_075
    {
        //public static string Problem051()
        //{
        //    Console.WriteLine("\n\n\n51. ");

        //    return null;
        //}

        //public static string Problem052()
        //{
        //    Console.WriteLine("\n\n\n52. ");

        //    return null;
        //}

        //public static string Problem053()
        //{
        //    Console.WriteLine("\n\n\n53. ");

        //    return null;
        //}

        //public static string Problem054()
        //{
        //    Console.WriteLine("\n\n\n54. ");

        //    return null;
        //}

        //public static string Problem055()
        //{
        //    Console.WriteLine("\n\n\n55. ");

        //    return null;
        //}

        //public static string Problem056()
        //{
        //    Console.WriteLine("\n\n\n56. ");

        //    return null;
        //}

        //public static string Problem057()
        //{
        //    Console.WriteLine("\n\n\n57. ");

        //    return null;
        //}

        //public static string Problem058()
        //{
        //    Console.WriteLine("\n\n\n58. ");

        //    return null;
        //}

        //public static string Problem059()
        //{
        //    Console.WriteLine("\n\n\n59. ");

        //    return null;
        //}

        //public static string Problem060()
        //{
        //    Console.WriteLine("\n\n\n60. ");

        //    return null;
        //}

        //public static string Problem061()
        //{
        //    Console.WriteLine("\n\n\n61. ");

        //    return null;
        //}

        //public static string Problem062()
        //{
        //    Console.WriteLine("\n\n\n62. ");

        //    return null;
        //}

        //public static string Problem063()
        //{
        //    Console.WriteLine("\n\n\n63. ");

        //    return null;
        //}

        //public static string Problem064()
        //{
        //    Console.WriteLine("\n\n\n64. ");

        //    return null;
        //}

        //public static string Problem065()
        //{
        //    Console.WriteLine("\n\n\n65. ");

        //    return null;
        //}

        //public static string Problem066()
        //{
        //    Console.WriteLine("\n\n\n66. ");

        //    return null;
        //}

        public static string Problem067()
        {
            Console.WriteLine("\n\n\n67. Find the maximum total from top to bottom in triangle.txt,\n\ta 15K text file containing a triangle with one-hundred rows.");

            var triangle = GetTriangle();

            ulong greatestSum = FindGreatestSumInTriangle(triangle);

            return greatestSum.ToString();
        }

        private static ulong FindGreatestSumInTriangle(List<List<ulong>> triangle)
        {
            // Start at the bottom of the triangle over-writing the parents with the addition of the parents and the parent's biggest child
            for (int parentRow = triangle.Count - 2; parentRow >= 0; parentRow--)
            {
                for (int parentCol = 0; parentCol < triangle[parentRow].Count; parentCol++)
                {
                    // Find the biggest child and add it to the parent
                    triangle[parentRow][parentCol] += Math.Max(triangle[parentRow + 1][parentCol], triangle[parentRow + 1][parentCol + 1]);
                }
            }

            // The top of the triangle now has the greatest sum
            return triangle[0][0];
        }

        private static List<List<ulong>> GetTriangle()
        {
            string path = @"Files/p067_triangle.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine($"\n\tUnable to find the file '{path}'...");
                return null;
            }

            string line;

            StreamReader file = new StreamReader(path);

            List<List<ulong>> result = new List<List<ulong>>();

            while ((line = file.ReadLine()) != null)
            {
                List<ulong> numbersInTheRow = new List<ulong>();

                line.Split(' ').ToList().ForEach(x => numbersInTheRow.Add(Convert.ToUInt64(x)));

                result.Add(numbersInTheRow);
            }

            file.Close();

            return result;
        }
                
        //public static string Problem068()
        //{
        //    Console.WriteLine("\n\n\n68. ");

        //    return null;
        //}

        //public static string Problem069()
        //{
        //    Console.WriteLine("\n\n\n69. ");

        //    return null;
        //}

        //public static string Problem070()
        //{
        //    Console.WriteLine("\n\n\n70. ");

        //    return null;
        //}

        //public static string Problem071()
        //{
        //    Console.WriteLine("\n\n\n71. ");

        //    return null;
        //}

        //public static string Problem072()
        //{
        //    Console.WriteLine("\n\n\n72. ");

        //    return null;
        //}

        //public static string Problem073()
        //{
        //    Console.WriteLine("\n\n\n73. ");

        //    return null;
        //}

        //public static string Problem074()
        //{
        //    Console.WriteLine("\n\n\n74. ");

        //    return null;
        //}

        //public static string Problem075()
        //{
        //    Console.WriteLine("\n\n\n75. ");

        //    return null;
        //}
    }
}