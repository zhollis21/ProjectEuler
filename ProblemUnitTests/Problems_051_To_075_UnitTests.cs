using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProblemUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Problems_051_To_075_UnitTests
    {
        [Test]
        public void Problem067_ReturnsCorrectAnswer()
        {
            Assert.AreEqual("7273", Problems_051_To_075.Problem067());
        }
    }
}