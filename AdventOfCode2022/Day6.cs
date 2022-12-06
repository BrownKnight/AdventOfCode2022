namespace AdventOfCode2022;

using System.Text.RegularExpressions;

public class Day6 : IDay<int?>
{
    public Day6()
    {
    }

    public int? Process1(string[] inputs)
    {
        var input = inputs[0];

        var windowStart = 0;
        var windowEnd = 4;
        while (windowEnd < input.Length)
        {
            var test = input[windowStart..windowEnd];
            if (test.Distinct().Count() == 4)
            {
                return windowEnd;
            }

            windowStart++;
            windowEnd++;
        }

        return -1;
    }

    public int? Process2(string[] inputs)
    {
        var input = inputs[0];

        var windowStart = 0;
        var windowEnd = 14;
        while (windowEnd < input.Length)
        {
            var test = input[windowStart..windowEnd];
            var distinctCount = test.Distinct().Count();
            if (distinctCount == 14)
            {
                return windowEnd;
            }

            windowStart++;
            windowEnd++;
        }

        return -1;
    }
}

