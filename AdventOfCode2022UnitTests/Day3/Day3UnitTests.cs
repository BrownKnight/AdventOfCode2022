using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day3UnitTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public Day3UnitTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Sample1()
        {
            var input = new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };
            var day = new Day3();

            var result = day.Process1(input);

            testOutputHelper.WriteLine($"result: {result}");
        }

        [Fact]
        public void Test1()
        {
            var input = File.ReadAllLines("./Day3/input.txt");
            var day = new Day3();

            var result = day.Process1(input);

            testOutputHelper.WriteLine($"result: {result}");
        }

        [Fact]
        public void Sample2()
        {
            var input = new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };
            var day = new Day3();

            var result = day.Process2(input);

            testOutputHelper.WriteLine($"result: {result}");
        }

        [Fact]
        public void Test2()
        {
            var input = File.ReadAllLines("./Day3/input.txt");
            var day = new Day3();

            var result = day.Process2(input);

            testOutputHelper.WriteLine($"result: {result}");
        }
    }
}

