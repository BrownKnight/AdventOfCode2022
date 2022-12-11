namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public class Day01UnitTests : DayUnitTestBase<Day01, int?>
{
    public Day01UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day01/input.txt", testOutputHelper)
    {
    }

    protected override string[] SampleInput1 => Array.Empty<string>();

    protected override string[] SampleInput2 => Array.Empty<string>();

    protected override int? Sample1Answer => null;

    protected override int? Sample2Answer => null;

    protected override int? Process1Answer => 68442;

    protected override int? Process2Answer => 204837;
}
