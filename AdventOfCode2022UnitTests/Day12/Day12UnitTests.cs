using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day12UnitTests : DayUnitTestBase<Day12, int?>
    {
        public Day12UnitTests(ITestOutputHelper testOutputHelper)
            : base("./Day12/input.txt", testOutputHelper)
        {
        }

        protected override string[] SampleInput1 => new[]
        {
            "Sabqponm",
            "abcryxxl",
            "accszExk",
            "acctuvwj",
            "abdefghi"
        };

        protected override string[] SampleInput2 => throw new NotImplementedException();

        protected override int? Sample1Answer => 31;

        protected override int? Sample2Answer => throw new NotImplementedException();

        protected override int? Process1Answer => throw new NotImplementedException();

        protected override int? Process2Answer => throw new NotImplementedException();
    }
}

