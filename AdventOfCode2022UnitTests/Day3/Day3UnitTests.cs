using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day3UnitTests : DayUnitTestBase<Day3>
    {
        protected override string[] SampleInput1 => new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };

        protected override string[] SampleInput2 => new[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };

        protected override int? Sample1Answer => 157;

        protected override int? Sample2Answer => 70;

        protected override int? Process1Answer => 7763;

        protected override int? Process2Answer => 2569;

        public Day3UnitTests(ITestOutputHelper testOutputHelper)
            : base("./Day3/input.txt", testOutputHelper)
        {
        }
    }
}
