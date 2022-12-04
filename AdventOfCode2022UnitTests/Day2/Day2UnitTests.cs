using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests;

public class Day2UnitTests : DayUnitTestBase<Day2>
{
    public Day2UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day2/input.txt", testOutputHelper)
    {
    }

    protected override string[] SampleInput1 => Array.Empty<string>();

    protected override string[] SampleInput2 => Array.Empty<string>();

    protected override int? Sample1Answer => null;

    protected override int? Sample2Answer => null;

    protected override int? Process1Answer => null;

    protected override int? Process2Answer => null;
}
