namespace AdventOfCode2022.UnitTests;
using Xunit.Abstractions;

public abstract class DayUnitTestBase<TDay> where TDay : IDay, new()
{
    private readonly string inputPath;

    public DayUnitTestBase(string inputPath, ITestOutputHelper testOutputHelper)
    {
        this.inputPath = inputPath;
        this.TestOutputHelper = testOutputHelper;
    }

    protected ITestOutputHelper TestOutputHelper { get; }

    protected abstract string[] SampleInput1 { get; }
    protected abstract string[] SampleInput2 { get; }

    protected abstract int? Sample1Answer { get; }
    protected abstract int? Sample2Answer { get; }
    protected abstract int? Process1Answer { get; }
    protected abstract int? Process2Answer { get; }

    [Fact]
    public void Sample1()
    {
        var day = new TDay();
        var result = day.Process1(this.SampleInput1);
        this.TestOutputHelper.WriteLine($"Result: {result}");

        if (this.Sample1Answer is not null)
        {
            Assert.Equal(this.Sample1Answer, result);
        }
    }

    [Fact]
    public void Sample2()
    {
        var day = new TDay();
        var result = day.Process2(this.SampleInput1);
        this.TestOutputHelper.WriteLine($"Result: {result}");

        if (this.Sample2Answer is not null)
        {
            Assert.Equal(this.Sample2Answer, result);
        }
    }

    [Fact]
    public void Process1()
    {
        var day = new TDay();
        var input = File.ReadAllLines(this.inputPath);

        var result = day.Process1(input);
        this.TestOutputHelper.WriteLine($"Result: {result}");

        if (this.Process1Answer is not null)
        {
            Assert.Equal(this.Process1Answer, result);
        }
    }

    [Fact]
    public void Process2()
    {
        var day = new TDay();
        var input = File.ReadAllLines(this.inputPath);

        var result = day.Process2(input);
        this.TestOutputHelper.WriteLine($"Result: {result}");

        if (this.Process2Answer is not null)
        {
            Assert.Equal(this.Process2Answer, result);
        }
    }
}

