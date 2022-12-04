using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day4UnitTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public Day4UnitTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Sample1()
        {
            var input = new[]
            {
                "2-4,6-8",
                "2-3,4-5",
                "5-7,7-9",
                "2-8,3-7",
                "6-6,4-6",
                "2-6,4-8"
            };
            var day = new Day4();

            var result = day.Process1(input);

            testOutputHelper.WriteLine($"result: {result}");
        }

        [Fact]
        public void Test1()
        {
            var input = File.ReadAllLines("./Day4/input.txt");
            var day = new Day4();

            var result = day.Process1(input);

            testOutputHelper.WriteLine($"result: {result}");
        }

        [Fact]
        public void Sample2()
        {
            var input = new[]
            {
                "2-4,6-8",
                "2-3,4-5",
                "5-7,7-9",
                "2-8,3-7",
                "6-6,4-6",
                "2-6,4-8"
            };
            var day = new Day4();

            var result = day.Process2(input);

            testOutputHelper.WriteLine($"result: {result}");
        }

        [Fact]
        public void Test2()
        {
            var input = File.ReadAllLines("./Day4/input.txt");
            var day = new Day4();

            var result = day.Process2(input);

            testOutputHelper.WriteLine($"result: {result}");
        }
    }
}

