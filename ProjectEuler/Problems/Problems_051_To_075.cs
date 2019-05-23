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
        //public static void Problem51()
        //{
        //    Console.WriteLine("\n\n\n51. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem52()
        //{
        //    Console.WriteLine("\n\n\n52. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem53()
        //{
        //    Console.WriteLine("\n\n\n53. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem54()
        //{
        //    Console.WriteLine("\n\n\n54. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem55()
        //{
        //    Console.WriteLine("\n\n\n55. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem56()
        //{
        //    Console.WriteLine("\n\n\n56. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem57()
        //{
        //    Console.WriteLine("\n\n\n57. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem58()
        //{
        //    Console.WriteLine("\n\n\n58. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem59()
        //{
        //    Console.WriteLine("\n\n\n59. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem60()
        //{
        //    Console.WriteLine("\n\n\n60. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem61()
        //{
        //    Console.WriteLine("\n\n\n61. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem62()
        //{
        //    Console.WriteLine("\n\n\n62. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem63()
        //{
        //    Console.WriteLine("\n\n\n63. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem64()
        //{
        //    Console.WriteLine("\n\n\n64. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem65()
        //{
        //    Console.WriteLine("\n\n\n65. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem66()
        //{
        //    Console.WriteLine("\n\n\n66. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        public static void Problem67()
        {
            Console.WriteLine("\n\n\n67. Find the maximum total from top to bottom in triangle.txt,\n\ta 15K text file containing a triangle with one-hundred rows.");

            var triangle = GetTriangle();

            ulong greatestSum = FindGreatestSumInTriangle(triangle);

            Console.WriteLine("\n\tAnswer: " + greatestSum);
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
            string path = @"Helpers/p067_triangle.txt";

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
                
        //public static void Problem68()
        //{
        //    Console.WriteLine("\n\n\n68. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem69()
        //{
        //    Console.WriteLine("\n\n\n69. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem70()
        //{
        //    Console.WriteLine("\n\n\n70. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem71()
        //{
        //    Console.WriteLine("\n\n\n71. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem72()
        //{
        //    Console.WriteLine("\n\n\n72. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem73()
        //{
        //    Console.WriteLine("\n\n\n73. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem74()
        //{
        //    Console.WriteLine("\n\n\n74. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}

        //public static void Problem75()
        //{
        //    Console.WriteLine("\n\n\n75. ");

        //    Console.WriteLine("\n\tAnswer: ");
        //}
    }
}