using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problems_1_To_25
    {
        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static void Problem1()
        {
            Console.WriteLine("\n\n\n1. Find the sum of all the multiples of 3 or 5 below 1000.");

            int sum = 0;

            for (int i = 1; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            Console.WriteLine("\n\tAnswer: " + sum);
        }

        /// <summary>
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        public static void Problem2()
        {
            Console.WriteLine("\n\n\n2. By considering the terms in the Fibonacci sequence whose values do not exceed four million,\nfind the sum of the even-valued terms.");

            long sum = 2;

            int num1 = 1, num2 = 2;
            int result = num1 + num2;

            while (result < 4000000)
            {
                if (result % 2 == 0)
                    sum += result;

                num1 = num2;
                num2 = result;
                result = num1 + num2;
            }

            Console.WriteLine("\n\tAnswer: " + sum);
        }

        /// <summary>
        /// What is the largest prime factor of the number 600851475143?
        /// </summary>
        public static void Problem3()
        {
            Console.WriteLine("\n\n\n3. What is the largest prime factor of the number 600851475143?");

            long number = 600851475143;

            DateTime startTime = DateTime.Now;

            // This loops from smallest to largest looking for numbers that are divisible by our target number.
            // If we find a number that is divisible, we check the other half of the product which is a fast way
            // to get the largest evenly divisible products.
            // Ex: If 34 is our tagert number and we find that 2 is divisible we know that the largest product into 34 is 17,
            // because 34 / 2 = 17 and if 17 is prime then we have found our answer.
            for (long i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    long diviser = number / i;
                    if (IsPrime(diviser))
                    {
                        Console.WriteLine("\nAnswer: " + diviser);
                        return;
                    }
                }
            }

            Console.WriteLine(DateTime.Now - startTime);
        }

        public static bool IsPrime(long number)
        {
            long squareRoot = (long)Math.Sqrt(number);

            for (long i = 2; i < squareRoot; i++)
                if (number % i == 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static void Problem4()
        {
            Console.WriteLine("\n\n\n4. Find the largest palindrome made from the product of two 3-digit numbers.");
        }

        /// <summary>
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public static void Problem5()
        {
            Console.WriteLine("\n\n\n5. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");
            
            for (int number = 1; number < int.MaxValue; number++)
            {
                if (IsDivisibleBy1Through20(number))
                {
                    Console.WriteLine("\nAnswer: " + number);
                    return;
                }
            }
        }

        public static bool IsDivisibleBy1Through20(int number)
        {
            for (int divisor = 1; divisor <= 20; divisor++)
                if (number % divisor != 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        public static void Problem6()
        {
            Console.WriteLine("\n\n\n6. Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");
        }

        /// <summary>
        /// What is the 10 001st prime number?
        /// </summary>
        public static void Problem7()
        {
            Console.WriteLine("\n\n\n7. What is the 10,001st prime number?");
        }

        /// <summary>
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        /// </summary>
        public static void Problem8()
        {
            Console.WriteLine("\n\n\n8. Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.\nWhat is the value of this product?\n");

            string number =
                "73167176531330624919225119674426574742355349194934" +
                "96983520312774506326239578318016984801869478851843" +
                "85861560789112949495459501737958331952853208805511" +
                "12540698747158523863050715693290963295227443043557" +
                "66896648950445244523161731856403098711121722383113" +
                "62229893423380308135336276614282806444486645238749" +
                "30358907296290491560440772390713810515859307960866" +
                "70172427121883998797908792274921901699720888093776" +
                "65727333001053367881220235421809751254540594752243" +
                "52584907711670556013604839586446706324415722155397" +
                "53697817977846174064955149290862569321978468622482" +
                "83972241375657056057490261407972968652414535100474" +
                "82166370484403199890008895243450658541227588666881" +
                "16427171479924442928230863465674813919123162824586" +
                "17866458359124566529476545682848912883142607690042" +
                "24219022671055626321111109370544217506941658960408" +
                "07198403850962455444362981230987879927244284909188" +
                "84580156166097919133875499200524063689912560717606" +
                "05886116467109405077541002256983155200055935729725" +
                "71636269561882670428252483600823257530420752963450";

            // Print the 1000 digit number to the console
            for (int i = 0; i + 50 < 1000; i += 50)
                Console.WriteLine("\t" + number.Substring(i, 50));

            long maxProduct = 0;
            int numberOfDigits = 13;

            for (int i = 0; i < number.Length - (numberOfDigits - 1); i++)
            {
                long product = 1;
                for (int j = i; j < i + numberOfDigits; j++)
                    product *= Convert.ToInt32(number[j].ToString());

                if (product > maxProduct)
                    maxProduct = product;
            }

            Console.WriteLine("\n\tAnswer: " + maxProduct);
        }

        /// <summary>
        /// There exists exactly one Pythagorean triplet (a^2 + b^2 = c^2) for which a + b + c = 1000. 
        /// Find the product abc.
        /// </summary>
        public static void Problem9()
        {
            Console.WriteLine("\n\n\n9. There exists exactly one Pythagorean triplet (a^2 + b^2 = c^2) for which a + b + c = 1000.\nFind the product abc.");
        }

        /// <summary>
        /// Find the sum of all the primes below two million.
        /// </summary>
        public static void Problem10()
        {
            Console.WriteLine("\n\n\n10. Find the sum of all the primes below two million.");
        }

        /// <summary>
        /// What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?
        /// </summary>
        public static void Problem11()
        {
            Console.WriteLine("\n\n\n11. What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally)\nin the 20×20 grid?\n");

            int[,] grid = new int[20, 20] {
                { 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08},
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00},
                { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65},
                { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91},
                { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80},
                { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50},
                { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70},
                { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21},
                { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72},
                { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95},
                { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92},
                { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57},
                { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58},
                { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40},
                { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66},
                { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69},
                { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36},
                { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16},
                { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54},
                { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48}};

            // Print the grid to the console
            for (int i = 0; i < 20; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 20; j++)
                    Console.Write(grid[i, j].ToString("D2"));

                Console.WriteLine();
            }

            long maxProduct = 0;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    long product;

                    // Going Left
                    if (i - 3 >= 0 && maxProduct < (product = grid[i, j] * grid[i - 1, j] * grid[i - 2, j] * grid[i - 3, j]))
                        maxProduct = product;

                    // Going Right
                    if (i + 3 < 20 && maxProduct < (product = grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j]))
                        maxProduct = product;

                    // Going Up
                    if (j - 3 >= 0 && maxProduct < (product = grid[i, j] * grid[i, j - 1] * grid[i, j - 2] * grid[i, j - 3]))
                        maxProduct = product;

                    // Going Down
                    if (j + 3 < 20 && maxProduct < (product = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3]))
                        maxProduct = product;

                    // Down Sloping Diagonal
                    if (i + 3 < 20 && j + 3 < 20 && maxProduct < (product = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3]))
                        maxProduct = product;

                    // Up Sloping Diagonal
                    if (i - 3 >= 0 && j + 3 < 20 && maxProduct < (product = grid[i, j] * grid[i - 1, j + 1] * grid[i - 2, j + 2] * grid[i - 3, j + 3]))
                        maxProduct = product;
                }
            }

            Console.WriteLine("\n\tAnswer: " + maxProduct);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem12()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem13()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem14()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem15()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem16()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem17()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem18()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem19()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem20()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem21()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem22()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem23()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem24()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public static void Problem25()
        //{
        //    Console.WriteLine("\n\n\n");
        //}

        public static void PrintAllProblems()
        {
            for (int i = 1; i <= 25; i++)
            {
                var type = typeof(Problems_1_To_25);
                var method = type.GetMethod($"Problem{i}");

                if (method != null)
                    method.Invoke(null, null);
                else
                    Console.WriteLine($"\n\nUnable to find Problem {i}...");
            }
        }

        public static bool PrintProblem(int problemNumber)
        {
            var type = typeof(Problems_1_To_25);
            var method = type.GetMethod($"Problem{problemNumber}");

            if (method != null)
            {
                method.Invoke(null, null);
                return true;
            }

            Console.WriteLine($"Unable to find Problem {problemNumber}...");
            return false;
        }
    }
}