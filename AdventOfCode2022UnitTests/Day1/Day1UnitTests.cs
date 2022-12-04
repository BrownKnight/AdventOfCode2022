using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests;

public class Day1UnitTests
{
    public Day1UnitTests(ITestOutputHelper testOutputHelper)
    {
        TestOutputHelper = testOutputHelper;
    }

    public ITestOutputHelper TestOutputHelper { get; }

    [Fact]
    public void Test1()
    {
        var input = File.ReadAllLines("./Day1/input.txt");
        var day1 = new Day1();

        var maxCalories = day1.Process1(input);

        TestOutputHelper.WriteLine($"maxCalories: {maxCalories}");
    }

    [Fact]
    public void Test2()
    {
        var input = File.ReadAllLines("./Day1/input.txt");
        var day1 = new Day1();

        var maxCalories = day1.Process2(input);

        TestOutputHelper.WriteLine($"top 3: {maxCalories}");
    }
}
