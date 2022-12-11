namespace AdventOfCode2022;

public class Day01 : IDay<int?>
{
    public int? Process1(string[] inputs)
    {
        var elfs = new Stack<int>();
        // Add first elf
        elfs.Push(0);

        foreach (var input in inputs)
        {
            switch (input)
            {
                case "":
                    elfs.Push(0);
                    break;
                default:
                    elfs.Push(elfs.Pop() + int.Parse(input));
                    break;
            }
        }

        return elfs.Max();
    }

    public int? Process2(string[] inputs)
    {
        var elfs = new Stack<int>();
        // Add first elf
        elfs.Push(0);

        foreach (var input in inputs)
        {
            switch (input)
            {
                case "":
                    elfs.Push(0);
                    break;
                default:
                    elfs.Push(elfs.Pop() + int.Parse(input));
                    break;
            }
        }

        // Find the top 3 counts
        return elfs.OrderByDescending(x => x).Take(3).Sum();
    }
}

