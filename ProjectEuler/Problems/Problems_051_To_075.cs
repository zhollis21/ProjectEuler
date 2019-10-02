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
        //public static string Problem51()
        //{
        //    Console.WriteLine("\n\n\n51. ");

        //    return null;
        //}

        //public static string Problem52()
        //{
        //    Console.WriteLine("\n\n\n52. ");

        //    return null;
        //}

        //public static string Problem53()
        //{
        //    Console.WriteLine("\n\n\n53. ");

        //    return null;
        //}

        //public static string Problem54()
        //{
        //    Console.WriteLine("\n\n\n54. ");

        //    return null;
        //}

        //public static string Problem55()
        //{
        //    Console.WriteLine("\n\n\n55. ");

        //    return null;
        //}

        //public static string Problem56()
        //{
        //    Console.WriteLine("\n\n\n56. ");

        //    return null;
        //}

        //public static string Problem57()
        //{
        //    Console.WriteLine("\n\n\n57. ");

        //    return null;
        //}

        //public static string Problem58()
        //{
        //    Console.WriteLine("\n\n\n58. ");

        //    return null;
        //}

        //public static string Problem59()
        //{
        //    Console.WriteLine("\n\n\n59. ");

        //    return null;
        //}

        //public static string Problem60()
        //{
        //    Console.WriteLine("\n\n\n60. ");

        //    return null;
        //}

        //public static string Problem61()
        //{
        //    Console.WriteLine("\n\n\n61. ");

        //    return null;
        //}

        //public static string Problem62()
        //{
        //    Console.WriteLine("\n\n\n62. ");

        //    return null;
        //}

        //public static string Problem63()
        //{
        //    Console.WriteLine("\n\n\n63. ");

        //    return null;
        //}

        //public static string Problem64()
        //{
        //    Console.WriteLine("\n\n\n64. ");

        //    return null;
        //}

        //public static string Problem65()
        //{
        //    Console.WriteLine("\n\n\n65. ");

        //    return null;
        //}

        //public static string Problem66()
        //{
        //    Console.WriteLine("\n\n\n66. ");

        //    return null;
        //}

        public static string Problem67()
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
                
        //public static string Problem68()
        //{
        //    Console.WriteLine("\n\n\n68. ");

        //    return null;
        //}

        //public static string Problem69()
        //{
        //    Console.WriteLine("\n\n\n69. ");

        //    return null;
        //}

        //public static string Problem70()
        //{
        //    Console.WriteLine("\n\n\n70. ");

        //    return null;
        //}

        //public static string Problem71()
        //{
        //    Console.WriteLine("\n\n\n71. ");

        //    return null;
        //}

        //public static string Problem72()
        //{
        //    Console.WriteLine("\n\n\n72. ");

        //    return null;
        //}

        //public static string Problem73()
        //{
        //    Console.WriteLine("\n\n\n73. ");

        //    return null;
        //}

        //public static string Problem74()
        //{
        //    Console.WriteLine("\n\n\n74. ");

        //    return null;
        //}

        //public static string Problem75()
        //{
        //    Console.WriteLine("\n\n\n75. ");

        //    return null;
        //}
    }
}