using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests;

public class Day2UnitTests
{
    public Day2UnitTests(ITestOutputHelper testOutputHelper)
    {
        TestOutputHelper = testOutputHelper;
    }

    public ITestOutputHelper TestOutputHelper { get; }

    [Fact]
    public void Sample2()
    {
        var input = new[]
        {
            "A Y",
            "B X",
            "C Z"
        };
        var day2 = new Day2();

        var player2Score = day2.Process2(input);

        TestOutputHelper.WriteLine($"sample player 2 score: {player2Score}");
    }

    [Fact]
    public void Test2()
    {
        var input = File.ReadAllLines("./Day2/input.txt");
        var day2 = new Day2();

        var player2Score = day2.Process2(input);

        TestOutputHelper.WriteLine($"player 2 score: {player2Score}");
    }

    [Fact]
    public void Sample()
    {
        var input = new[]
        {
            "A Y",
            "B X",
            "C Z"
        };
        var day2 = new Day2();

        var result = day2.Process1(input);

        TestOutputHelper.WriteLine($"result: {result}");
    }

    [Fact]
    public void Test1()
    {
        var input = File.ReadAllLines("./Day2/input.txt");
        var day2 = new Day2();

        var result = day2.Process1(input);

        TestOutputHelper.WriteLine($"result: {result}");
    }
}
