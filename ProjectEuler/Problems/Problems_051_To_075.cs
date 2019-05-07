﻿using System;
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
            Console.WriteLine("\n\n\n67. ");

            DateTime startTime = DateTime.Now;
            var triangle = GetTriangle();

            FindGreatestSumInTriangleMultithread(0, 0, triangle, out ulong greatestSum);

            Console.WriteLine("\n\tAnswer: " + greatestSum);

            Console.WriteLine("\tTook: " + (DateTime.Now - startTime));
        }

        private static void FindGreatestSumInTriangleMultithread(int row, int col, List<List<ulong>> triangle, out ulong greatestSum)
        {
            // If we aren't at the bottom
            if (row < triangle.Count() - 1)
            {
                ulong leftSum = 0, rightSum = 0;

                if (row < 3) // We don't want too many threads
                {
                    var leftThread = new Thread(() => FindGreatestSumInTriangleMultithread(row + 1, col, triangle, out leftSum));

                    var rightThread = new Thread(() => FindGreatestSumInTriangleMultithread(row + 1, col + 1, triangle, out rightSum));

                    leftThread.Start();
                    rightThread.Start();

                    leftThread.Join();
                    rightThread.Join();
                }
                else
                {
                    leftSum = FindGreatestSumInTriangle(row + 1, col, triangle);

                    rightSum = FindGreatestSumInTriangle(row + 1, col + 1, triangle);
                }
                // We are adding bottom up by picking the biggest child
                greatestSum = triangle[row][col] + Math.Max(leftSum, rightSum);
            }

            greatestSum = triangle[row][col];
        }

        private static ulong FindGreatestSumInTriangle(int row, int col, List<List<ulong>> triangle)
        {
            // If we aren't at the bottom
            if (row < triangle.Count() - 1)
            {
                ulong leftSum = FindGreatestSumInTriangle(row + 1, col, triangle);

                ulong rightSum = FindGreatestSumInTriangle(row + 1, col + 1, triangle);

                // We are adding bottom up by picking the biggest child
                return triangle[row][col] + Math.Max(leftSum, rightSum);
            }

            return triangle[row][col];
        }

        public static List<List<ulong>> GetTriangle()
        {
            string path = @"Helpers/p067_triangle.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine($"Unable to find the file '{path}'...");
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