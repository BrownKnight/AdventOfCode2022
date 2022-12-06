namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public class Day4UnitTests : DayUnitTestBase<Day4, int?>
{
    protected override string[] SampleInput1 => new[]
        {
            "2-4,6-8",
            "2-3,4-5",
            "5-7,7-9",
            "2-8,3-7",
            "6-6,4-6",
            "2-6,4-8"
        };

    protected override string[] SampleInput2 => new[]
        {
            "2-4,6-8",
            "2-3,4-5",
            "5-7,7-9",
            "2-8,3-7",
            "6-6,4-6",
            "2-6,4-8"
        };

    protected override int? Sample1Answer => 2;

    protected override int? Sample2Answer => 4;

    protected override int? Process1Answer => 524;

    protected override int? Process2Answer => 798;

    public Day4UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day4/input.txt", testOutputHelper)
    {
    }
}

