using System;
using Xunit.Abstractions;

namespace AdventOfCode2022.UnitTests
{
    public class Day07UnitTests : DayUnitTestBase<Day07, int?>
    {
        public Day07UnitTests(ITestOutputHelper testOutputHelper)
            : base("./Day07/input.txt", testOutputHelper)
        {
        }

        protected override string[] SampleInput1 => new[]
        {
            "$ cd /",
            "$ ls",
            "dir a",
            "14848514 b.txt",
            "8504156 c.dat",
            "dir d",
            "$ cd a",
            "$ ls",
            "dir e",
            "29116 f",
            "2557 g",
            "62596 h.lst",
            "$ cd e",
            "$ ls",
            "584 i",
            "$ cd ..",
            "$ cd ..",
            "$ cd d",
            "$ ls",
            "4060174 j",
            "8033020 d.log",
            "5626152 d.ext",
            "7214296 k"
        };

        protected override string[] SampleInput2 => new[]
        {
            "$ cd /",
            "$ ls",
            "dir a",
            "14848514 b.txt",
            "8504156 c.dat",
            "dir d",
            "$ cd a",
            "$ ls",
            "dir e",
            "29116 f",
            "2557 g",
            "62596 h.lst",
            "$ cd e",
            "$ ls",
            "584 i",
            "$ cd ..",
            "$ cd ..",
            "$ cd d",
            "$ ls",
            "4060174 j",
            "8033020 d.log",
            "5626152 d.ext",
            "7214296 k"
        };

        protected override int? Sample1Answer => 95437;

        protected override int? Sample2Answer => 24933642;

        protected override int? Process1Answer => 1427048;

        protected override int? Process2Answer => 2940614;
    }
}

