namespace AdventOfCode2022;

using System.Text.RegularExpressions;

public class Day5 : IDay<string>
{
    private static readonly string MoveInstructionRegex = @"move (\d+) from (\d+) to (\d+)";
    public Day5()
    {
    }

    public string Process1(string[] inputs)
    {
        var stackInputs = inputs.Where(x => !x.Contains("move")).Reverse();
        var moveInstructions = inputs.Where(x => x.Contains("move"));

        // build the stacks from the input
        var numStacks = stackInputs.ElementAt(1).Length / 4 + 1;
        var stacks = new Stack<char>[numStacks];

        foreach (var input in stackInputs)
        {
            for (var i = 0; i < numStacks; i++)
            {
                if (!input.Contains('['))
                {
                    // Does not contain a stack item
                    continue;
                }

                var charIndex = (i * 4) + 1;
                var stackItem = input[charIndex];
                if (!char.IsWhiteSpace(stackItem))
                {
                    stacks[i] ??= new();
                    stacks[i].Push(stackItem);
                }
            }
        }

        // process the instructions
        foreach(var instruction in moveInstructions)
        {
            var matches = Regex.Match(instruction, MoveInstructionRegex).Groups;
            var numToMove = int.Parse(matches[1].ToString());
            var srcStack = int.Parse(matches[2].ToString()) - 1;
            var destStack = int.Parse(matches[3].ToString()) - 1;

            for (var i = 0; i < numToMove; i++)
            {
                stacks[destStack].Push(stacks[srcStack].Pop());
            }
        }

        return string.Join(string.Empty, stacks.Select(x => x.Peek()));
    }

    public string Process2(string[] inputs)
    {
        var stackInputs = inputs.Where(x => !x.Contains("move")).Reverse();
        var moveInstructions = inputs.Where(x => x.Contains("move"));

        // build the stacks from the input
        var numStacks = stackInputs.ElementAt(1).Length / 4 + 1;
        var stacks = new Stack<char>[numStacks];

        foreach (var input in stackInputs)
        {
            for (var i = 0; i < numStacks; i++)
            {
                if (!input.Contains('['))
                {
                    // Does not contain a stack item
                    continue;
                }

                var charIndex = (i * 4) + 1;
                var stackItem = input[charIndex];
                if (!char.IsWhiteSpace(stackItem))
                {
                    stacks[i] ??= new();
                    stacks[i].Push(stackItem);
                }
            }
        }

        // process the instructions
        foreach (var instruction in moveInstructions)
        {
            var matches = Regex.Match(instruction, MoveInstructionRegex).Groups;
            var numToMove = int.Parse(matches[1].ToString());
            var srcStack = int.Parse(matches[2].ToString()) - 1;
            var destStack = int.Parse(matches[3].ToString()) - 1;

            var srcItems = stacks[srcStack].Take(numToMove).Reverse();
            foreach (var stackItem in srcItems)
            {
                stacks[srcStack].Pop();
                stacks[destStack].Push(stackItem);
            }
        }

        return string.Join(string.Empty, stacks.Select(x => x.Peek()));
    }
}

