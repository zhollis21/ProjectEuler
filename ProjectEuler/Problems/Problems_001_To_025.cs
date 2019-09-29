using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problems_001_To_025
    {
        public static void Problem1()
        {
            Console.WriteLine("\n\n\n1. Find the sum of all the multiples of 3 or 5 below 1000.");

            int sum = 0;

            for (int i = 1; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            Console.WriteLine("\n\tAnswer: " + sum);
        }

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

        public static void Problem3()
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
                    if (IsPrime(diviser))
                    {
                        Console.WriteLine("\nAnswer: " + diviser);
                        return;
                    }
                }
            }
        }

        public static bool IsPrime(long number)
        {
            long squareRoot = (long)Math.Sqrt(number);

            for (long i = 2; i <= squareRoot; i++)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static void Problem4()
        {
            Console.WriteLine("\n\n\n4. Find the largest palindrome made from the product of two 3-digit numbers.");

            int maxProduct = 0;

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int product = i * j;

                    if (IsPalendome(product.ToString()) && product > maxProduct)
                        maxProduct = product;
                }
            }

            Console.WriteLine("\nAnswer: " + maxProduct);
        }

        private static bool IsPalendome(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            int midpoint = word.Length / 2;

            for (int front = 0, back = word.Length - 1; front <= midpoint; front++, back--)
            {
                if (word[front] != word[back])
                    return false;
            }

            return true;
        }

        public static void Problem5()
        {
            Console.WriteLine("\n\n\n5. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");

            // Incremant by 20 because that is the biggest divisor
            for (int number = 20; number < int.MaxValue; number += 20)
            {
                if (IsDivisibleBy1Through20(number))
                {
                    Console.WriteLine("\nAnswer: " + number);
                    return;
                }
            }
        }

        private static bool IsDivisibleBy1Through20(int number)
        {
            for (int divisor = 1; divisor <= 20; divisor++)
                if (number % divisor != 0)
                    return false;

            return true;
        }

        public static void Problem6()
        {
            Console.WriteLine("\n\n\n6. Find the difference between the sum of the squares of\nthe first one hundred natural numbers and the square of the sum.");

            long sumOfSquares = 0;
            long sumOfFirstHundredNums = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                sumOfFirstHundredNums += i;
            }

            Console.WriteLine("\n\tAnswer: " + (sumOfFirstHundredNums * sumOfFirstHundredNums - sumOfSquares));
        }

        public static void Problem7()
        {
            Console.WriteLine("\n\n\n7. What is the 10,001st prime number?");

            List<int> primeNumbers = new List<int>() { 2 };
            int number = 3;

            while (primeNumbers.Count < 10001)
            {
                bool isPrime = true;

                for (int primeIndex = 0; primeIndex < primeNumbers.Count; primeIndex++)
                {
                    if (number % primeNumbers[primeIndex] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    primeNumbers.Add(number);

                number += 2;
            }

            Console.WriteLine("\n\tAnswer: " + primeNumbers[10000]);
        }

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

        public static void Problem9()
        {
            Console.WriteLine("\n\n\n9. There exists exactly one Pythagorean triplet (a^2 + b^2 = c^2) for which a + b + c = 1000.\nFind the product abc.");
        }

        public static void Problem10()
        {
            Console.WriteLine("\n\n\n10. Find the sum of all the primes below two million (this could take a minute or two).");

            long sum = 0;
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

            Console.WriteLine("\n\tAnswer: " + sum);
        }

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

        public static void Problem12()
        {
            Console.WriteLine("\n\n\n12. What is the value of the first triangle number to have over five hundred divisors?");
            long triangleNumber = 1;

            for (int i = 2; i < int.MaxValue; i++)
            {
                triangleNumber += i;
                if (NumberOfFactors(triangleNumber) > 500)
                    break;
            }

            Console.WriteLine("\n\tAnswer: " + triangleNumber);
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

        public static void Problem13()
        {
            Console.WriteLine("\n\n\n13. Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.");

            // NOTE: I could have used BigInt, but I thought it would be fun to do some string addition to mix it up
            List<string> numbers = GetListOfNumbers();
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

            Console.WriteLine("\n\tAnswer: " + sumOfNumbers.Substring(0, 10));
        }

        private static List<string> GetListOfNumbers()
        {
            return new List<string>() {
            "37107287533902102798797998220837590246510135740250",
            "46376937677490009712648124896970078050417018260538",
            "74324986199524741059474233309513058123726617309629",
            "91942213363574161572522430563301811072406154908250",
            "23067588207539346171171980310421047513778063246676",
            "89261670696623633820136378418383684178734361726757",
            "28112879812849979408065481931592621691275889832738",
            "44274228917432520321923589422876796487670272189318",
            "47451445736001306439091167216856844588711603153276",
            "70386486105843025439939619828917593665686757934951",
            "62176457141856560629502157223196586755079324193331",
            "64906352462741904929101432445813822663347944758178",
            "92575867718337217661963751590579239728245598838407",
            "58203565325359399008402633568948830189458628227828",
            "80181199384826282014278194139940567587151170094390",
            "35398664372827112653829987240784473053190104293586",
            "86515506006295864861532075273371959191420517255829",
            "71693888707715466499115593487603532921714970056938",
            "54370070576826684624621495650076471787294438377604",
            "53282654108756828443191190634694037855217779295145",
            "36123272525000296071075082563815656710885258350721",
            "45876576172410976447339110607218265236877223636045",
            "17423706905851860660448207621209813287860733969412",
            "81142660418086830619328460811191061556940512689692",
            "51934325451728388641918047049293215058642563049483",
            "62467221648435076201727918039944693004732956340691",
            "15732444386908125794514089057706229429197107928209",
            "55037687525678773091862540744969844508330393682126",
            "18336384825330154686196124348767681297534375946515",
            "80386287592878490201521685554828717201219257766954",
            "78182833757993103614740356856449095527097864797581",
            "16726320100436897842553539920931837441497806860984",
            "48403098129077791799088218795327364475675590848030",
            "87086987551392711854517078544161852424320693150332",
            "59959406895756536782107074926966537676326235447210",
            "69793950679652694742597709739166693763042633987085",
            "41052684708299085211399427365734116182760315001271",
            "65378607361501080857009149939512557028198746004375",
            "35829035317434717326932123578154982629742552737307",
            "94953759765105305946966067683156574377167401875275",
            "88902802571733229619176668713819931811048770190271",
            "25267680276078003013678680992525463401061632866526",
            "36270218540497705585629946580636237993140746255962",
            "24074486908231174977792365466257246923322810917141",
            "91430288197103288597806669760892938638285025333403",
            "34413065578016127815921815005561868836468420090470",
            "23053081172816430487623791969842487255036638784583",
            "11487696932154902810424020138335124462181441773470",
            "63783299490636259666498587618221225225512486764533",
            "67720186971698544312419572409913959008952310058822",
            "95548255300263520781532296796249481641953868218774",
            "76085327132285723110424803456124867697064507995236",
            "37774242535411291684276865538926205024910326572967",
            "23701913275725675285653248258265463092207058596522",
            "29798860272258331913126375147341994889534765745501",
            "18495701454879288984856827726077713721403798879715",
            "38298203783031473527721580348144513491373226651381",
            "34829543829199918180278916522431027392251122869539",
            "40957953066405232632538044100059654939159879593635",
            "29746152185502371307642255121183693803580388584903",
            "41698116222072977186158236678424689157993532961922",
            "62467957194401269043877107275048102390895523597457",
            "23189706772547915061505504953922979530901129967519",
            "86188088225875314529584099251203829009407770775672",
            "11306739708304724483816533873502340845647058077308",
            "82959174767140363198008187129011875491310547126581",
            "97623331044818386269515456334926366572897563400500",
            "42846280183517070527831839425882145521227251250327",
            "55121603546981200581762165212827652751691296897789",
            "32238195734329339946437501907836945765883352399886",
            "75506164965184775180738168837861091527357929701337",
            "62177842752192623401942399639168044983993173312731",
            "32924185707147349566916674687634660915035914677504",
            "99518671430235219628894890102423325116913619626622",
            "73267460800591547471830798392868535206946944540724",
            "76841822524674417161514036427982273348055556214818",
            "97142617910342598647204516893989422179826088076852",
            "87783646182799346313767754307809363333018982642090",
            "10848802521674670883215120185883543223812876952786",
            "71329612474782464538636993009049310363619763878039",
            "62184073572399794223406235393808339651327408011116",
            "66627891981488087797941876876144230030984490851411",
            "60661826293682836764744779239180335110989069790714",
            "85786944089552990653640447425576083659976645795096",
            "66024396409905389607120198219976047599490197230297",
            "64913982680032973156037120041377903785566085089252",
            "16730939319872750275468906903707539413042652315011",
            "94809377245048795150954100921645863754710598436791",
            "78639167021187492431995700641917969777599028300699",
            "15368713711936614952811305876380278410754449733078",
            "40789923115535562561142322423255033685442488917353",
            "44889911501440648020369068063960672322193204149535",
            "41503128880339536053299340368006977710650566631954",
            "81234880673210146739058568557934581403627822703280",
            "82616570773948327592232845941706525094512325230608",
            "22918802058777319719839450180888072429661980811197",
            "77158542502016545090413245809786882778948721859617",
            "72107838435069186155435662884062257473692284509516",
            "20849603980134001723930671666823555245252804609722",
            "53503534226472524250874054075591789781264330331690"};
        }

        public static void Problem14()
        {
            Console.WriteLine("\n\n\n14. Which starting number, under one million, produces the longest chain in the Collatz sequence.");

            int maxSequenceCount = 0;
            int numberWithMaxSequence = 0;

            for (int number = 1; number < 1000000; number++)
            {
                int count = CollatzSequenceCount(number);

                if (count >= maxSequenceCount)
                {
                    maxSequenceCount = count;
                    numberWithMaxSequence = number;
                }
            }

            Console.WriteLine($"\n\tAnswer: {numberWithMaxSequence} had the longest chain ({maxSequenceCount}).");
        }

        private static int CollatzSequenceCount(long number)
        {
            int sequenceCount = 1;

            while (number > 1)
            {
                if (number % 2 == 0) // Even
                {
                    number /= 2;
                    sequenceCount++;
                }

                else // Odd, we do both an odd and then an even formula to save computation cycles
                {
                    number = (number * 3 + 1) / 2;
                    sequenceCount += 2;
                }
            }

            return sequenceCount;
        }

        public static void Problem15()
        {
            Console.WriteLine("\n\n\n15. Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,\n" +
                "there are exactly 6 routes to the bottom right corner. How many such routes are there through a 20×20 grid?");

            Console.WriteLine($"\n\tAnswer: " + CalculateNumberOfRoutes(20, 20));
        }

        private static BigInteger CalculateNumberOfRoutes(int rightEdge, int downEdge)
        {
            // Formula is:
            // (rightSteps + leftSteps)! / (rightSteps! * leftSteps!)
            int numberOfSteps = rightEdge + downEdge;

            BigInteger numberOfTotalRoutes = 1;
            BigInteger numberOfRightRoutes = 1;
            BigInteger numberOfDownRoutes = 1;


            for (int i = 2; i <= numberOfSteps; i++)
            {
                // Total Number of Combinations
                numberOfTotalRoutes *= i;

                // Number of repeated rights
                if (i <= rightEdge)
                    numberOfRightRoutes *= i;

                // Number of repeated lefts
                if (i <= downEdge)
                    numberOfDownRoutes *= i;
            }

            return numberOfTotalRoutes / (numberOfRightRoutes * numberOfDownRoutes);
        }

        public static void Problem16()
        {
            Console.WriteLine("\n\n\n16. What is the sum of the digits of the number 2^1000?");

            BigInteger product = 1;

            for (int i = 0; i < 1000; i++)
                product *= 2;

            // You have to ToString the char in the sum function so it doesn't 
            // pull the character value when converting to an integer
            int sumOfDigits = product.ToString().Sum(x => Convert.ToInt32(x.ToString()));

            Console.WriteLine("\n\tAnswer: " + sumOfDigits);
        }

        public static void Problem17()
        {
            Console.WriteLine("\n\n\n17. If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?");

            // NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) 
            // contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
            // The use of "and" when writing out numbers is in compliance with British usage.

            int sumOfLetters = 0;

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"{i} has {sumOfLetters += LettersInANumber(i)} letters.");
            }

            Console.WriteLine("\n\tAnswer: " + sumOfLetters);
        }

        private static int LettersInANumber(int number)
        {
            int numberOfDigits = number.ToString().Length;
            int sumOfLetters = 0;

            sumOfLetters += LettersInTheOnesPlace(number);
            sumOfLetters += LettersInTheTensPlace(number);

            // We need to add the 'and'
            if (sumOfLetters > 0 && number >= 100)
                sumOfLetters += 3;

            sumOfLetters += LettersInTheHundredsPlace(number);
            sumOfLetters += LettersInTheThousandsPlace(number);

            return sumOfLetters;
        }

        private static int LettersInTheOnesPlace(int number)
        {
            number %= 10;

            if (number == 0)
                return 0;

            else if (number == 1 || number == 2 || number == 6)
                return 3;

            else if (number == 4 || number == 5 || number == 9)
                return 4;

            return 5; // 3, 7, 8
        }

        private static int LettersInTheTensPlace(int number)
        {
            number %= 100;

            if (number < 10)
                return 0;

            else if (number < 20)
            {
                if (number == 10)
                    return 3;

                else if (number == 11 || number == 12)
                    return 3; // 6 - 3 = 3, This prevents double counting from the one's place

                else if (number == 13 || number == 14 || number == 18 || number == 19)
                    return 8 - LettersInTheOnesPlace(number); // This prevents double counting from the one's place

                else if (number == 15 || number == 16)
                    return 7 - LettersInTheOnesPlace(number); // This prevents double counting from the one's place

                else // 17
                    return 4; // 9 - 5 = 4, This prevents double counting from the one's place
            }

            // Zero out the 1's place
            number -= number % 10;

            if (number == 20 || number == 30 || number == 80 || number == 90)
                return 6;

            else if (number == 40 || number == 50 || number == 60)
                return 5;

            else // 70
                return 7;
        }

        private static int LettersInTheHundredsPlace(int number)
        {
            number %= 1000;

            // Move the Hundred's Place to the One's Place
            number /= 100;

            if (number < 1)
                return 0;

            // take the base number and just add the number of letters in 'hundred'
            return LettersInTheOnesPlace(number) + 7;
        }

        private static int LettersInTheThousandsPlace(int number)
        {
            number %= 10000;

            // Move the Thousand's Place to the One's Place
            number /= 1000;

            if (number < 1)
                return 0;

            // take the base number and just add the number of letters in 'thousand'
            return LettersInTheOnesPlace(number) + 8;
        }

        public static void Problem18()
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

            Console.WriteLine("\n\n\tAnswer: " + FindGreatestSumInTriangle(0, 0, GetTriangleOfNumbers()));
        }

        private static int FindGreatestSumInTriangle(int row, int col, List<List<int>> triangle)
        {
            // If we aren't at the bottom
            if (row < triangle.Count() - 1)
            {

                int leftSum = FindGreatestSumInTriangle(row + 1, col, triangle);

                int rightSum = FindGreatestSumInTriangle(row + 1, col + 1, triangle);

                // We are adding bottom up by picking the biggest child
                return triangle[row][col] + Math.Max(leftSum, rightSum);
            }

            return triangle[row][col];
        }

        private static List<List<int>> GetTriangleOfNumbers()
        {
            return new List<List<int>>
            {
                new List<int> { 75 },
                new List<int> { 95, 64 },
                new List<int> { 17, 47, 82 },
                new List<int> { 18, 35, 87, 10 },
                new List<int> { 20, 04, 82, 47, 65 },
                new List<int> { 19, 01, 23, 75, 03, 34 },
                new List<int> { 88, 02, 77, 73, 07, 63, 67 },
                new List<int> { 99, 65, 04, 28, 06, 16, 70, 92 },
                new List<int> { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
                new List<int> { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
                new List<int> { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
                new List<int> { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
                new List<int> { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
                new List<int> { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
                new List<int> { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 }
            };
        }

        public static void Problem19()
        {
            Console.WriteLine("\n\n\n19. How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?");

            int sundaysOnTheFirst = 0;

            // Loop over the first of every month and see if it's a sunday
            for (DateTime date = new DateTime(1901, 1, 1); date.Year < 2001; date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    sundaysOnTheFirst++;
            }

            Console.WriteLine("\n\tAnswer: " + sundaysOnTheFirst);
        }

        public static void Problem20()
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

            Console.WriteLine("\n\tAnswer: " + sumOfDigits);
        }

        public static void Problem21()
        {
            Console.WriteLine("\n\n\n21. Evaluate the sum of all the amicable numbers under 10000.");

            int sumOfAmicableNumbers = 0;

            for (int i = 2; i < 10000; i++)
            {
                int sumOfDivisors = SumOfProperDivisors(i);

                // If the sum of the sum of the divisors is equal to i
                // then i is an amicable numbers
                if (sumOfDivisors != i && SumOfProperDivisors(sumOfDivisors) == i)
                    sumOfAmicableNumbers += i;

                // Also note that while you could record both numbers i and sumOfDivisors,
                // I'm just keeping a simple total so I won't have to keep track of a list.
                // However this does mean duplicate calculations, but it is still probably
                // more performant than searching to see if something is in a list or not
            }

            Console.WriteLine("\n\tAnswer: " + sumOfAmicableNumbers);
        }

        private static int SumOfProperDivisors(int num)
        {
            int sumOfDivisors = 1;
            int midpoint = num / 2;

            for (int i = 2; i <= midpoint; i++)
            {
                if (num % i == 0)
                    sumOfDivisors += i;
            }

            return sumOfDivisors;
        }

        public static void Problem22()
        {
            Console.WriteLine("\n\n\n22. Using names.txt, a 46K text file containing over five-thousand first names, begin by sorting it\n\tinto alphabetical order. " +
                              "Then working out the alphabetical value for each name, multiply this\n\tvalue by its alphabetical position in the list to obtain a name score. " +
                              "For example, when the\n\tlist is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is\n\tthe 938th name in the list. " +
                              "So, COLIN would obtain a score of 938 × 53 = 49714. " +
                              "What is the\n\ttotal of all the name scores in the file ? ");

            var sortedNames = GetNamesInAlphaOrder();

            BigInteger sumOfNameScores = 0;

            for (int i = 0; i < sortedNames.Count; i++)
            {
                // We have to add 1 to i, because i is the index, but we need the position starting from 1
                // i.e. Element 0 is the 1st thing, not the 0th thing
                sumOfNameScores += (i + 1) * SumOfCharacterPositions(sortedNames[i]);
            }

            Console.WriteLine("\n\tAnswer: " + sumOfNameScores);
        }

        private static int SumOfCharacterPositions(string name)
        {
            int sum = 0;
            int referenceCode = 'A' - 1;

            // We grab each character code and subract it from the reference code,
            // so we can get what number of the alphabet it is
            foreach (int characterCode in name)
            {
                sum += characterCode - referenceCode;
            }

            return sum;
        }

        private static List<string> GetNamesInAlphaOrder()
        {
            string path = @"Helpers/p022_names.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine($"\n\tUnable to find the file '{path}'...");
                return null;
            }

            string line;

            StreamReader file = new StreamReader(path);

            List<string> result = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                result.AddRange(line.Split(','));
            }

            file.Close();

            result.Sort();

            return result;
        }

        public static void Problem23()
        {
            Console.WriteLine("\n\n\n23. A number n is called abundant if the sum of its proper divisors is greater than n." +
                              "\n\tFind the sum of all the positive integers which cannot be written as the sum of two abundant numbers.");

            List<int> abundantNumbers = new List<int>();
            List<int> nonAbundantSumNumbers = new List<int>();

            for (int i = 1; i < 28124; i++)
            {
                // We go ahead and put all possible numbers in the non sum list
                nonAbundantSumNumbers.Add(i);

                if (SumOfProperDivisors(i) > i)
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

            Console.WriteLine("\n\tAnswer: " + nonAbundantSumNumbers.Sum());
        }

        public static void Problem24()
        {
            Console.WriteLine("\n\n\n24. What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?");

            List<PermutationCharacter> characters = new List<PermutationCharacter>();

            for (int i = 0; i < 10; i++)
            {
                characters.Add(new PermutationCharacter(char.Parse(i.ToString())));
            }

            var result = RecursivePermutations(characters, 0);

            Console.Write("\n\tAnswer: ");
            result.Value.ForEach(x => Console.Write(x));
            Console.WriteLine();
        }

        private static KeyValuePair<int, List<char>> RecursivePermutations(List<PermutationCharacter> characters, int count)
        {
            // If there is only one available letter we know we are at the last layer of the recursion
            if (characters.Where(x => x.IsAvailable).Count() == 1)
            {
                if (++count == 1000000)
                    return new KeyValuePair<int, List<char>>(count, new List<char> { characters.Where(x => x.IsAvailable).First().Character });
                else
                    return new KeyValuePair<int, List<char>>(count, null);
            }

            foreach (PermutationCharacter pc in characters)
            {
                // Since we don't allow repetition in our permutations, we mark the ones in use and unmark them when we are done
                if (pc.IsAvailable)
                {
                    pc.IsAvailable = false;

                    var result = RecursivePermutations(characters, count);
                    count = result.Key;

                    // We only return a non null value when we reached 1 million
                    if (result.Value != null)
                    {
                        // We insert at the beginning since we go last char to first char
                        result.Value.Insert(0, pc.Character);
                        return result;
                    }

                    pc.IsAvailable = true;
                }
            }

            // We didn't find the 1 millionth yet, so we go back a level
            return new KeyValuePair<int, List<char>>(count, null);
        }

        // Simple class to hold a character and a bool to let us know if we can pick it
        private class PermutationCharacter
        {
            public PermutationCharacter(char character)
            {
                Character = character;
            }

            public bool IsAvailable = true;

            public char Character;
        }

        public static void Problem25()
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

            Console.WriteLine("\n\tAnswer: " + index);
        }
    }
}