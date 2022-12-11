    using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day8UnitTests : DayUnitTestBase<Day8, int?>
    {
        public Day8UnitTests(ITestOutputHelper testOutputHelper)
            : base("./Day8/input.txt", testOutputHelper)
        {
        }

        protected override string[] SampleInput1 => new[]
        {
            "30373",
            "25512",
            "65332",
            "33549",
            "35390"
        };

        protected override string[] SampleInput2 => new[]
        {
            "30373",
            "25512",
            "65332",
            "33549",
            "35390"
        };

        protected override int? Sample1Answer => 21;

        protected override int? Sample2Answer => 8;

        protected override int? Process1Answer => 1705;

        protected override int? Process2Answer => null;
    }
}

