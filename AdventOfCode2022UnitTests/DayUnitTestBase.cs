namespace AdventOfCode2022.UnitTests;

using System.Text;
using Xunit.Abstractions;

public abstract class DayUnitTestBase<TDay, TResult>
    where TDay : IDay<TResult>, new()
{
    private readonly string inputPath;

    public DayUnitTestBase(string inputPath, ITestOutputHelper testOutputHelper)
    {
        this.inputPath = inputPath;
        this.TestOutputHelper = testOutputHelper;
        Console.SetOut(new Converter(testOutputHelper));
    }

    protected ITestOutputHelper TestOutputHelper { get; }

    protected abstract string[] SampleInput1 { get; }
    protected abstract string[] SampleInput2 { get; }

    protected abstract TResult? Sample1Answer { get; }
    protected abstract TResult? Sample2Answer { get; }
    protected abstract TResult? Process1Answer { get; }
    protected abstract TResult? Process2Answer { get; }

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
        var result = day.Process2(this.SampleInput2);
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

    private class Converter : TextWriter
    {
        private readonly ITestOutputHelper _output;
        public Converter(ITestOutputHelper output)
        {
            _output = output;
        }
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
        public override void WriteLine(string? message)
        {
            _output.WriteLine(message);
        }
        public override void WriteLine(string format, params object[] args)
        {
            _output.WriteLine(format, args);
        }

        public override void Write(char value)
        {
            throw new NotSupportedException("This text writer only supports WriteLine(string) and WriteLine(string, params object[]).");
        }
    }
}

