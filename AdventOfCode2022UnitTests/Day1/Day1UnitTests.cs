using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests;

public class Day1UnitTests : DayUnitTestBase<Day1>
{
    public Day1UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day1/input.txt", testOutputHelper)
    {
    }

    protected override string[] SampleInput1 => Array.Empty<string>();

    protected override string[] SampleInput2 => Array.Empty<string>();

    protected override int? Sample1Answer => null;

    protected override int? Sample2Answer => null;

    protected override int? Process1Answer => 68442;

    protected override int? Process2Answer => 204837;
}
