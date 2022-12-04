using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
	public abstract class DayUnitTestBase<TDay> where TDay : IDay, new()
	{
        private readonly string inputPath;

        public DayUnitTestBase(string inputPath, ITestOutputHelper testOutputHelper)
		{
            this.inputPath = inputPath;
            TestOutputHelper = testOutputHelper;
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
            var result = day.Process1(SampleInput1);
            TestOutputHelper.WriteLine($"Result: {result}");

            if (Sample1Answer is not null)
            {
                Assert.Equal(Sample1Answer, result);
            }
        }

        [Fact]
        public void Sample2()
        {
            var day = new TDay();
            var result = day.Process2(SampleInput1);
            TestOutputHelper.WriteLine($"Result: {result}");

            if (Sample2Answer is not null)
            {
                Assert.Equal(Sample2Answer, result);
            }
        }

        [Fact]
        public void Process1()
        {
            var day = new TDay();
            var input = File.ReadAllLines(inputPath);

            var result = day.Process1(input);
            TestOutputHelper.WriteLine($"Result: {result}");

            if (Process1Answer is not null)
            {
                Assert.Equal(Process1Answer, result);
            }
        }

        [Fact]
        public void Process2()
        {
            var day = new TDay();
            var input = File.ReadAllLines(inputPath);

            var result = day.Process2(input);
            TestOutputHelper.WriteLine($"Result: {result}");

            if (Process2Answer is not null)
            {
                Assert.Equal(Process2Answer, result);
            }
        }
    }
}

