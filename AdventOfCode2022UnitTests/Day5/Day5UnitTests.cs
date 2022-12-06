namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public class Day5UnitTests : DayUnitTestBase<Day5, string>
{
    protected override string[] SampleInput1 => new[]
        {
            "    [D]    ",
            "[N] [C]    ",
            "[Z] [M] [P]",
            " 1   2   3 ",
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };

    protected override string[] SampleInput2 => new[]
        {
            "    [D]    ",
            "[N] [C]    ",
            "[Z] [M] [P]",
            " 1   2   3 ",
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };

    protected override string? Sample1Answer => "CMZ";

    protected override string? Sample2Answer => "MCD";

    protected override string? Process1Answer => "QNHWJVJZW";

    protected override string? Process2Answer => "BPCZJLFJW";

    public Day5UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day5/input.txt", testOutputHelper)
    {
    }
}

