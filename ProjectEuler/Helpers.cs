﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using ProjectEuler.Models;

namespace ProjectEuler
{
    public class Helpers
    {
        public static bool IsPrime(long number)
        {
            long squareRoot = (long)Math.Sqrt(number);

            if (number != 2 && number % 2 == 0)
                return false;

            for (long i = 3; i <= squareRoot; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static bool IsPalendome(string word)
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

        public static bool IsDivisibleBy1Through20(int number)
        {
            for (int divisor = 1; divisor <= 20; divisor++)
                if (number % divisor != 0)
                    return false;

            return true;
        }

        public static List<string> GetListOfNumbersForProblem007()
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

        public static int CollatzSequenceCount(long number)
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

        public static BigInteger CalculateNumberOfRoutes(int rightEdge, int downEdge)
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

        public static int LettersInANumber(int number)
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

        public static int LettersInTheOnesPlace(int number)
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

        public static int LettersInTheTensPlace(int number)
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

        public static int LettersInTheHundredsPlace(int number)
        {
            number %= 1000;

            // Move the Hundred's Place to the One's Place
            number /= 100;

            if (number < 1)
                return 0;

            // take the base number and just add the number of letters in 'hundred'
            return LettersInTheOnesPlace(number) + 7;
        }

        public static int LettersInTheThousandsPlace(int number)
        {
            number %= 10000;

            // Move the Thousand's Place to the One's Place
            number /= 1000;

            if (number < 1)
                return 0;

            // take the base number and just add the number of letters in 'thousand'
            return LettersInTheOnesPlace(number) + 8;
        }

        public static int FindGreatestSumInTriangle(int row, int col, List<List<int>> triangle)
        {
            // If we aren't at the bottom
            if (row < triangle.Count - 1)
            {

                int leftSum = FindGreatestSumInTriangle(row + 1, col, triangle);

                int rightSum = FindGreatestSumInTriangle(row + 1, col + 1, triangle);

                // We are adding bottom up by picking the biggest child
                return triangle[row][col] + Math.Max(leftSum, rightSum);
            }

            return triangle[row][col];
        }

        public static List<List<int>> GetTriangleOfNumbers()
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

        public static int SumOfProperDivisors(int num)
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

        public static int SumOfCharacterPositions(string name)
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

        public static List<string> GetNamesInAlphaOrder()
        {
            string path = @"Files/p022_names.txt";

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

        public static KeyValuePair<int, List<char>> FindNthRecursivePermutation(List<PermutationCharacter> characters, int nthCount)
        {
            // If there is only one available letter we know we are at the last layer of the recursion
            if (characters.Where(x => x.IsAvailable).Count() == 1)
            {
                // We subract for every combination until nthCount is 0, at which point we have found the one they wanted.
                if (--nthCount == 0)
                    return new KeyValuePair<int, List<char>>(nthCount, new List<char> { characters.Where(x => x.IsAvailable).First().Character });
                else
                    return new KeyValuePair<int, List<char>>(nthCount, null);
            }

            foreach (PermutationCharacter pc in characters)
            {
                // Since we don't allow repetition in our permutations, we mark the ones in use and unmark them when we are done
                if (pc.IsAvailable)
                {
                    pc.IsAvailable = false;

                    var result = FindNthRecursivePermutation(characters, nthCount);
                    nthCount = result.Key;

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

            // We didn't find the nth one yet, so we go back a level
            return new KeyValuePair<int, List<char>>(nthCount, null);
        }
    }
}