namespace FizzBuzz.Tests
{
    using NUnit.Framework;
    using Should;

    [TestFixture]
    public class FizzBuzzRunnerTests
    {
        private FizzBuzzRunner _runner;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _runner = new FizzBuzzRunner();
            _runner.AddRule(3, 15, "FizzBuzz");
            _runner.AddRule(2, 3, "Fizz");
            _runner.AddRule(1, 5, "Buzz");
        }

        [Test]
        public void ShouldHonorWeight()
        {
            var result = _runner.RunSingleUsingRules(30);

            result.ShouldEqual("FizzBuzz");

        }

        [Test]
        public void ShouldPrintReplacementString()
        {
            var result = _runner.RunSingleUsingRules(9);

            result.ShouldEqual("Fizz");

        }

        [Test]
        public void ShouldPrintNumberAsString()
        {
            var result = _runner.RunSingleUsingRules(1);

            result.ShouldEqual("1");
        }
    }
}
