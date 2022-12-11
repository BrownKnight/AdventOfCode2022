using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day11UnitTests : DayUnitTestBase<Day11, int?>
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

        protected override string[] SampleInput2 => throw new NotImplementedException();

        protected override int? Sample1Answer => 10605;

        protected override int? Sample2Answer => throw new NotImplementedException();

        protected override int? Process1Answer => throw new NotImplementedException();

        protected override int? Process2Answer => throw new NotImplementedException();
    }
}

