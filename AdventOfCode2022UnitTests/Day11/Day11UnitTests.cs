using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day11UnitTests : DayUnitTestBase<Day11, long?>
    {
        public Day11UnitTests(ITestOutputHelper testOutputHelper)
            : base("./Day11/input.txt", testOutputHelper)
        {
        }

        protected override string[] SampleInput1 => new[]
        {
            "Monkey 0:",
            "  Starting items: 79, 98",
            "  Operation: new = old * 19",
            "  Test: divisible by 23",
            "    If true: throw to monkey 2",
            "    If false: throw to monkey 3",
            "",
            "Monkey 1:",
            "  Starting items: 54, 65, 75, 74",
            "  Operation: new = old + 6",
            "  Test: divisible by 19",
            "    If true: throw to monkey 2",
            "    If false: throw to monkey 0",
            "",
            "Monkey 2:",
            "  Starting items: 79, 60, 97",
            "  Operation: new = old * old",
            "  Test: divisible by 13",
            "    If true: throw to monkey 1",
            "    If false: throw to monkey 3",
            "",
            "Monkey 3:",
            "  Starting items: 74",
            "  Operation: new = old + 3",
            "  Test: divisible by 17",
            "    If true: throw to monkey 0",
            "    If false: throw to monkey 1"
        };

        protected override string[] SampleInput2 => SampleInput1;

        protected override long? Sample1Answer => 10605;

        protected override long? Sample2Answer => 2713310158;

        protected override long? Process1Answer => null;

        protected override long? Process2Answer => null;
    }
}

