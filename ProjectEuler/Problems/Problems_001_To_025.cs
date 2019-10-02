using ProjectEuler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problems_001_To_025
    {
        public static string Problem001()
        {
            Console.WriteLine("\n\n\n1. Find the sum of all the multiples of 3 or 5 below 1000.");

            int sum = 0;

            for (int i = 1; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            return sum.ToString();
        }

        public static string Problem002()
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

            return sum.ToString();
        }

        public static string Problem003()
        {
            Console.WriteLine("\n\n\n3. What is the largest prime factor of the number 600851475143?");

            long number = 600851475143;

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
                    if (Helpers.IsPrime(diviser))
                    {
                        return diviser.ToString();
                    }
                }
            }

            return "Unable to find the answer...";
        }

        public static string Problem004()
        {
            Console.WriteLine("\n\n\n4. Find the largest palindrome made from the product of two 3-digit numbers.");

            int maxProduct = 0;

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int product = i * j;

                    if (Helpers.IsPalendome(product.ToString()) && product > maxProduct)
                        maxProduct = product;
                }
            }

            return maxProduct.ToString();
        }

        public static string Problem005()
        {
            Console.WriteLine("\n\n\n5. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");

            // Incremant by 20 because that is the biggest divisor
            for (int number = 20; number < int.MaxValue; number += 20)
            {
                if (Helpers.IsDivisibleBy1Through20(number))
                {
                    return number.ToString();
                }
            }

            return "Unable to find the answer...";
        }

        public static string Problem006()
        {
            Console.WriteLine("\n\n\n6. Find the difference between the sum of the squares of\nthe first one hundred natural numbers and the square of the sum.");

            long sumOfSquares = 0;
            long sumOfFirstHundredNums = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                sumOfFirstHundredNums += i;
            }

            long difference = sumOfFirstHundredNums * sumOfFirstHundredNums - sumOfSquares;

            return difference.ToString();
        }

        public static string Problem007()
        {
            Console.WriteLine("\n\n\n7. What is the 10,001st prime number?");

            int counter = 1; // We start off knowing 2 is prime
            int number = 3;

           while (counter < 10001)
            {
                if (Helpers.IsPrime(number))
                {
                    counter++;
                }

                number += 2;
            }

            return (number - 2).ToString();
        }

        public static string Problem008()
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

            return maxProduct.ToString();
        }

        public static string Problem009()
        {
            Console.WriteLine("\n\n\n9. There exists exactly one Pythagorean triplet (a^2 + b^2 = c^2) for which a + b + c = 1000.\nFind the product abc.");

            int a = 0, b = 0;
            double c = 0;

            for (a = 1; a < 500; a++)
            {
                for (b = a + 1; b < 500; b++)
                {
                    c = Math.Sqrt(a * a + b * b);

                    if (c > b && a + b + c == 1000)
                    {
                        int product = a * b * (int)c;

                        return product.ToString();
                    }
                }
            }

            return "Unable to find the answer...";
        }

        public static string Problem010()
        {
            Console.WriteLine("\n\n\n10. Find the sum of all the primes below two million (this could take a minute or two).");

            long sum = 2; // We start with 2 in our listOfPrimes so we also start with 2 as our sum
            List<int> listOfPrimes = new List<int>() { 2 };

            for (int number = 3; number < 2000000; number += 2)
            {
                bool isPrime = true;
                int primeCount = listOfPrimes.Count;

                for (int primeIndex = 0; primeIndex < primeCount; primeIndex++)
                {
                    if (number % listOfPrimes[primeIndex] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    listOfPrimes.Add(number);
                    sum += number;
                }
            }

            return sum.ToString();
        }

        public static string Problem011()
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

            return maxProduct.ToString();
        }

        public static string Problem012()
        {
            Console.WriteLine("\n\n\n12. What is the value of the first triangle number to have over five hundred divisors?");
            long triangleNumber = 1;

            for (int i = 2; i < int.MaxValue; i++)
            {
                triangleNumber += i;
                if (NumberOfFactors(triangleNumber) > 500)
                    break;
            }

            return triangleNumber.ToString();
        }

        private static int NumberOfFactors(long number)
        {
            // This is designed only for numbers greater than 1
            // We start at 2 because we already know 1 and itself go into it
            int numberOfFactors = 2;
            int squareRootOfNumber = (int)Math.Sqrt(number);

            for (int divisor = 2; divisor < squareRootOfNumber; divisor++)
            {
                if (number % divisor == 0)
                {
                    // This is a bit complex, but basically we are trying to record both ends of the factors
                    // Doing so allows us to only have to go to the sqrt instead of half of the number
                    // Example: 2 is a factor of 40, so if we divide 40 by 2 we get the other factor (20)
                    // However we need to make sure we don't double count the square root
                    // Example: 2 is a factor of 4, but if we divide 4 by 2 we get 2, which we should only count as one factor
                    if (number == squareRootOfNumber)
                        numberOfFactors++;
                    else
                        numberOfFactors += 2;
                }
            }

            return numberOfFactors;
        }

        public static string Problem013()
        {
            Console.WriteLine("\n\n\n13. Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.");

            // NOTE: I could have used BigInt, but I thought it would be fun to do some string addition to mix it up
            List<string> numbers = Helpers.GetListOfNumbersForProblem007();
            int additionCarryOver = 0;
            string sumOfNumbers = string.Empty;

            for (int digitIndex = 49; digitIndex >= 0; digitIndex--)
            {
                int sum = additionCarryOver;

                for (int numberIndex = 0; numberIndex < numbers.Count; numberIndex++)
                {
                    // We have to ToString the char, otherwise it will give us the character code and not the number version
                    sum += Convert.ToInt32(numbers[numberIndex][digitIndex].ToString());
                }

                // Last digit goes into the total sum
                sumOfNumbers = (sum % 10) + sumOfNumbers;

                // The rest of the digits go into the carry over
                additionCarryOver = sum / 10;
            }

            // If we have added all the numbers and there is carry over, we place it in front
            sumOfNumbers = additionCarryOver + sumOfNumbers;

            return sumOfNumbers.Substring(0, 10);
        }

        public static string Problem014()
        {
            Console.WriteLine("\n\n\n14. Which starting number, under one million, produces the longest chain in the Collatz sequence.");

            int maxSequenceCount = 0;
            int numberWithMaxSequence = 0;

            for (int number = 1; number < 1000000; number++)
            {
                int count = Helpers.CollatzSequenceCount(number);

                if (count >= maxSequenceCount)
                {
                    maxSequenceCount = count;
                    numberWithMaxSequence = number;
                }
            }

            return numberWithMaxSequence.ToString();
        }

        public static string Problem015()
        {
            Console.WriteLine("\n\n\n15. Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,\n" +
                "there are exactly 6 routes to the bottom right corner. How many such routes are there through a 20×20 grid?");

            BigInteger answer = Helpers.CalculateNumberOfRoutes(20, 20);
            return answer.ToString();
        }

        public static string Problem016()
        {
            Console.WriteLine("\n\n\n16. What is the sum of the digits of the number 2^1000?");

            BigInteger product = 1;

            for (int i = 0; i < 1000; i++)
                product *= 2;

            // You have to ToString the char in the sum function so it doesn't 
            // pull the character value when converting to an integer
            int sumOfDigits = product.ToString().Sum(x => Convert.ToInt32(x.ToString()));

            return sumOfDigits.ToString();
        }

        public static string Problem017()
        {
            Console.WriteLine("\n\n\n17. If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?");

            // NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) 
            // contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
            // The use of "and" when writing out numbers is in compliance with British usage.

            int sumOfLetters = 0;

            for (int i = 1; i <= 1000; i++)
            {
                sumOfLetters += Helpers.LettersInANumber(i);
            }

            return sumOfLetters.ToString();
        }

        public static string Problem018()
        {
            Console.WriteLine("\n\n\n18. Find the maximum total from top to bottom of the triangle below.");
            Console.WriteLine(@"
                     75
                    95 64
                  17 47 82
                 18 35 87 10
               20 04 82 47 65
              19 01 23 75 03 34
            88 02 77 73 07 63 67
           99 65 04 28 06 16 70 92
         41 41 26 56 83 40 80 70 33
        41 48 72 33 47 32 37 16 94 29
      53 71 44 65 25 43 91 52 97 51 14
     70 11 33 28 77 73 17 78 39 68 17 57
   91 71 52 38 17 14 91 43 58 50 27 29 48
  63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23");

            var answer = Helpers.FindGreatestSumInTriangle(0, 0, Helpers.GetTriangleOfNumbers());
            return answer.ToString();
        }

        public static string Problem019()
        {
            Console.WriteLine("\n\n\n19. How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?");

            int sundaysOnTheFirst = 0;

            // Loop over the first of every month and see if it's a sunday
            for (DateTime date = new DateTime(1901, 1, 1); date.Year < 2001; date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    sundaysOnTheFirst++;
            }

            return sundaysOnTheFirst.ToString();
        }

        public static string Problem020()
        {
            Console.WriteLine("\n\n\n20. Find the sum of the digits in the number 100!");

            BigInteger product = 1;

            for (int i = 2; i < 101; i++)
            {
                product *= i;
            }

            int sumOfDigits = 0;
            string digits = product.ToString();

            for (int i = 0; i < digits.Length; i++)
            {
                sumOfDigits += Convert.ToInt32(digits[i].ToString());
            }

            return sumOfDigits.ToString();
        }

        public static string Problem021()
        {
            Console.WriteLine("\n\n\n21. Evaluate the sum of all the amicable numbers under 10000.");

            int sumOfAmicableNumbers = 0;

            for (int i = 2; i < 10000; i++)
            {
                int sumOfDivisors = Helpers.SumOfProperDivisors(i);

                // If the sum of the sum of the divisors is equal to i
                // then i is an amicable numbers
                if (sumOfDivisors != i && Helpers.SumOfProperDivisors(sumOfDivisors) == i)
                    sumOfAmicableNumbers += i;

                // Also note that while you could record both numbers i and sumOfDivisors,
                // I'm just keeping a simple total so I won't have to keep track of a list.
                // However this does mean duplicate calculations, but it is still probably
                // more performant than searching to see if something is in a list or not
            }

            return sumOfAmicableNumbers.ToString();
        }

        public static string Problem022()
        {
            Console.WriteLine("\n\n\n22. Using names.txt, a 46K text file containing over five-thousand first names, begin by sorting it\n\tinto alphabetical order. " +
                              "Then working out the alphabetical value for each name, multiply this\n\tvalue by its alphabetical position in the list to obtain a name score. " +
                              "For example, when the\n\tlist is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is\n\tthe 938th name in the list. " +
                              "So, COLIN would obtain a score of 938 × 53 = 49714. " +
                              "What is the\n\ttotal of all the name scores in the file ? ");

            var sortedNames = Helpers.GetNamesInAlphaOrder();

            if (sortedNames == null || sortedNames.Count < 1)
                return "An error occurred: Unable to get names.";

            BigInteger sumOfNameScores = 0;

            for (int i = 0; i < sortedNames.Count; i++)
            {
                // We have to add 1 to i, because i is the index, but we need the position starting from 1
                // i.e. Element 0 is the 1st thing, not the 0th thing
                sumOfNameScores += (i + 1) * Helpers.SumOfCharacterPositions(sortedNames[i]);
            }

            return sumOfNameScores.ToString();
        }

        public static string Problem023()
        {
            Console.WriteLine("\n\n\n23. A number n is called abundant if the sum of its proper divisors is greater than n." +
                              "\n\tFind the sum of all the positive integers which cannot be written as the sum of two abundant numbers.");

            List<int> abundantNumbers = new List<int>();
            List<int> nonAbundantSumNumbers = new List<int>();

            for (int i = 1; i < 28124; i++)
            {
                // We go ahead and put all possible numbers in the non sum list
                nonAbundantSumNumbers.Add(i);

                if (Helpers.SumOfProperDivisors(i) > i)
                    abundantNumbers.Add(i);
            }

            // Remove all the combinations of abundant numbers from the non sum list
            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                // We start j at i so we do not to duplicate previous sum calculations
                // i.e. 1 + 6 is the same as 6 + 1, so there is no point in starting at the beginning
                for (int j = i; j < abundantNumbers.Count; j++)
                {
                    nonAbundantSumNumbers.Remove(abundantNumbers[i] + abundantNumbers[j]);
                }
            }

            var answer = nonAbundantSumNumbers.Sum();
            return answer.ToString();
        }

        public static string Problem024()
        {
            Console.WriteLine("\n\n\n24. What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?");

            List<PermutationCharacter> characters = new List<PermutationCharacter>();

            for (int i = 0; i < 10; i++)
            {
                characters.Add(new PermutationCharacter(char.Parse(i.ToString())));
            }

            var result = Helpers.FindNthRecursivePermutation(characters, 1000000);

            if (result.Value == null)
                return "Unable to find the answer...";

            string finalPermutation = string.Empty;
            result.Value.ForEach(x => finalPermutation += x);
            return finalPermutation;
        }

        public static string Problem025()
        {
            Console.WriteLine("\n\n\n25. What is the index of the first term in the Fibonacci sequence to contain 1000 digits?");

            int index = 2;
            BigInteger previousNumber = 1;
            BigInteger currentNumber = 1;

            do
            {
                BigInteger temp = previousNumber;
                previousNumber = currentNumber;
                currentNumber += temp;
                index++;
            }
            while (currentNumber.ToString().Length < 1000);

            return index.ToString();
        }
    }
}