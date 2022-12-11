using System;
namespace AdventOfCode2022
{
    public class Day10 : IDay<string?>
    {
        public Day10()
        {
        }

        public string? Process1(string[] inputs)
        {
            var clockCycleValues = CalculateCycleValues(inputs);

            return Enumerable.Sum(new[]
            {
                clockCycleValues.ElementAt(19) * 20,
                clockCycleValues.ElementAt(59) * 60,
                clockCycleValues.ElementAt(99) * 100,
                clockCycleValues.ElementAt(139) * 140,
                clockCycleValues.ElementAt(179) * 180,
                clockCycleValues.ElementAt(219) * 220
            }).ToString();
        }

        private static List<int> CalculateCycleValues(string[] inputs)
        {
            var clockCycleValues = new List<int>();

            var lastIsAdd = false;
            foreach (var input in inputs)
            {
                var lastValue = clockCycleValues.LastOrDefault(1);
                if (input == "noop")
                {
                    if (!lastIsAdd)
                    {
                        clockCycleValues.Add(lastValue);
                    }
                    lastIsAdd = false;
                }
                else
                {
                    // Add 1 clock cycles
                    clockCycleValues.Add(lastValue);

                    if (!lastIsAdd)
                    {
                        clockCycleValues.Add(lastValue);
                    }

                    var operand = int.Parse(input[5..]);
                    var newValue = lastValue + operand;
                    clockCycleValues.Add(newValue);
                    lastIsAdd = true;
                }
            }

            return clockCycleValues;
        }

        public string? Process2(string[] inputs)
        {
            var clockCycleValues = CalculateCycleValues(inputs);
            var screen = new List<char>();

            foreach (var (val, idx) in clockCycleValues.Select((v, i) => (v, i)))
            {
                var positionInRow = (idx % 40) + 1;
                var valLeft = val;
                var valRight = val + 2;
                if (positionInRow >= valLeft && positionInRow <= valRight)
                {
                    screen.Add('#');
                }
                else
                {
                    screen.Add('.');
                }
            }

            Console.WriteLine(new String(screen.ToArray()[..40]));
            Console.WriteLine(new String(screen.ToArray()[40..80]));
            Console.WriteLine(new String(screen.ToArray()[80..120]));
            Console.WriteLine(new String(screen.ToArray()[120..160]));
            Console.WriteLine(new String(screen.ToArray()[160..200]));
            Console.WriteLine(new String(screen.ToArray()[200..240]));
            return string.Join('\n', screen.Chunk(40).Select(x => new string(x)));
        }
    }
}

