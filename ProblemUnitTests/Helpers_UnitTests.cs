using NUnit.Framework;
using ProjectEuler;

namespace ProblemUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Helpers_UnitTests
    {
        [Test]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(12, false)]
        [TestCase(13, true)]
        [TestCase(14, false)]
        [TestCase(15, false)]
        [TestCase(16, false)]
        [TestCase(17, true)]
        [TestCase(18, false)]
        [TestCase(19, true)]
        [TestCase(20, false)]
        [TestCase(21, false)]
        public void IsPrime_ReturnsExpectedResult(int number, bool expectedResult)
        {
            bool actualResult = Helpers.IsPrime(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(" ", true)]
        [TestCase(null, false)]
        [TestCase("z", true)]
        [TestCase("", false)]
        [TestCase("racecar", true)]
        [TestCase("racezar", false)]
        [TestCase("boob", true)]
        [TestCase("mood", false)]
        [TestCase("zzizz", true)]
        [TestCase("tttttz", false)]
        public void IsPalendrome_ReturnsExpectedResult(string word, bool expectedResult)
        {
            bool actualResult = Helpers.IsPalendome(word);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}