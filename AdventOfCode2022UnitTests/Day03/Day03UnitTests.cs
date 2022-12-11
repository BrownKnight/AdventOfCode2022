namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public class Day03UnitTests : DayUnitTestBase<Day03, int?>
{
    protected override string[] SampleInput1 => new[]
        {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"
        };

    protected override string[] SampleInput2 => new[]
        {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"
        };

    protected override int? Sample1Answer => 157;

    protected override int? Sample2Answer => 70;

    protected override int? Process1Answer => 7763;

    protected override int? Process2Answer => 2569;

    public Day03UnitTests(ITestOutputHelper testOutputHelper)
        : base("./Day03/input.txt", testOutputHelper)
    {
    }
}
