using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProblemUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Problems_026_To_050_UnitTests
    {
        [Test]
        public void Problem028_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("669171001", Problems_026_To_050.Problem028());
        }

        [Test]
        public void Problem029_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("9183", Problems_026_To_050.Problem029());
        }
    }
}