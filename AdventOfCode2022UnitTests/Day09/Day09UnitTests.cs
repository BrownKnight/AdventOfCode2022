using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day09UnitTests : DayUnitTestBase<Day09, int?>
    {
        public Day09UnitTests(ITestOutputHelper testOutputHelper)
            : base("./Day09/input.txt", testOutputHelper)
        {
        }

        protected override string[] SampleInput1 => new[]
        {
            "R 4",
            "U 4",
            "L 3",
            "D 1",
            "R 4",
            "D 1",
            "L 5",
            "R 2"
        };

        protected override string[] SampleInput2 => new[]
        {
            "R 5",
            "U 8",
            "L 8",
            "D 3",
            "R 17",
            "D 10",
            "L 25",
            "U 20"
        };

        protected override int? Sample1Answer => 13;

        protected override int? Sample2Answer => 36;

        protected override int? Process1Answer => 6406;

        protected override int? Process2Answer => null;

        [Fact]
        public void TupleTest()
        {
            Assert.Equal((x: 1, y: 2), (x: 1, y: 2));
        }
    }
}

