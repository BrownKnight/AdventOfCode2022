namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public class Day02UnitTests : DayUnitTestBase<Day02, int?>
{
    public Day02UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day02/input.txt", testOutputHelper)
    {
    }

    protected override string[] SampleInput1 => Array.Empty<string>();

    protected override string[] SampleInput2 => Array.Empty<string>();

    protected override int? Sample1Answer => null;

    protected override int? Sample2Answer => null;

    protected override int? Process1Answer => null;

    protected override int? Process2Answer => null;
}
