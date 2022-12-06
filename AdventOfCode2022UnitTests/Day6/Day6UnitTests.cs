namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public class Day6UnitTests : DayUnitTestBase<Day6, int?>
{
    protected override string[] SampleInput1 => new[]
        {
            "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"
        };

    protected override string[] SampleInput2 => new[]
        {
            "bvwbjplbgvbhsrlpgdmjqwftvncz"
        };

    protected override int? Sample1Answer => 10;

    protected override int? Sample2Answer => 23;

    protected override int? Process1Answer => 1760;

    protected override int? Process2Answer => null;

    public Day6UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day6/input.txt", testOutputHelper)
    {
    }
}

