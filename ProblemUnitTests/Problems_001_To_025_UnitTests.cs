using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProblemUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Problems_001_To_025_UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

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
            bool actualResult = Problems_001_To_025.IsPrime(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Problem001_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("233168", Problems_001_To_025.Problem001());
        }

        [Test]
        public void Problem002_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("4613732", Problems_001_To_025.Problem002());
        }

        [Test]
        public void Problem003_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("6857", Problems_001_To_025.Problem003());
        }

        [Test]
        public void Problem004_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("906609", Problems_001_To_025.Problem004());
        }

        [Test]
        public void Problem005_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("232792560", Problems_001_To_025.Problem005());
        }

        [Test]
        public void Problem006_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("25164150", Problems_001_To_025.Problem006());
        }

        [Test]
        public void Problem007_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("104743", Problems_001_To_025.Problem007());
        }

        [Test]
        public void Problem008_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("23514624000", Problems_001_To_025.Problem008());
        }

        [Test]
        public void Problem009_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("31875000", Problems_001_To_025.Problem009());
        }

        [Test]
        public void Problem010_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("142913828922", Problems_001_To_025.Problem010());
        }

        [Test]
        public void Problem011_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("70600674", Problems_001_To_025.Problem011());
        }

        [Test]
        public void Problem012_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("76576500", Problems_001_To_025.Problem012());
        }

        [Test]
        public void Problem013_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("5537376230", Problems_001_To_025.Problem013());
        }

        [Test]
        public void Problem014_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("837799", Problems_001_To_025.Problem014());
        }

        [Test]
        public void Problem015_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("137846528820", Problems_001_To_025.Problem015());
        }

        [Test]
        public void Problem016_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("1366", Problems_001_To_025.Problem016());
        }

        [Test]
        public void Problem017_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("21124", Problems_001_To_025.Problem017());
        }

        [Test]
        public void Problem018_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("1074", Problems_001_To_025.Problem018());
        }

        [Test]
        public void Problem019_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("171", Problems_001_To_025.Problem019());
        }

        [Test]
        public void Problem020_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("648", Problems_001_To_025.Problem020());
        }

        [Test]
        public void Problem021_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("31626", Problems_001_To_025.Problem021());
        }

        [Test]
        public void Problem022_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("871198282", Problems_001_To_025.Problem022());
        }

        [Test]
        public void Problem023_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("4179871", Problems_001_To_025.Problem023());
        }

        [Test]
        public void Problem024_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("2783915460", Problems_001_To_025.Problem024());
        }

        [Test]
        public void Problem025_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("4782", Problems_001_To_025.Problem025());
        }
    }
}