using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2022
{
    public class Day11 : IDay<int?>
    {
        public Day11()
        {
        }

        public int? Process1(string[] inputs)
        {
            var monkeys = new List<Monkey>();
            for (var i = 0; i < inputs.Length; i++)
            {
                var input = inputs[i];
                if (input.StartsWith("Monkey", StringComparison.InvariantCulture))
                {
                    monkeys.Add(new Monkey());
                }
                else if (input.Contains("Starting items", StringComparison.InvariantCulture))
                {
                    input = input.Replace("  Starting items: ", string.Empty);
                    var items = input.Split(", ");
                    foreach (var item in items)
                    {
                        monkeys.Last().Items.Enqueue(int.Parse(item));
                    }
                }
                else if (input.Contains("Operation", StringComparison.InvariantCulture))
                {
                    var regex = Regex.Match(input, @"Operation: new = (.+) (.) (.+)");
                    var left = regex.Groups[1].Value;
                    var op = regex.Groups[2].Value;
                    var right = regex.Groups[3].Value;
                    monkeys.Last().Operation = GetOperation(left, op, right);
                }
                else if (input.Contains("Test", StringComparison.InvariantCulture))
                {
                    var divisableBy = Regex.Match(input, @"(\d+)").Groups[0].Value;
                    var ifTrue = Regex.Match(inputs[++i], @"(\d+)").Groups[0].Value;
                    var ifFalse = Regex.Match(inputs[++i], @"(\d+)").Groups[0].Value;

                    monkeys.Last().Test = (val) => val % int.Parse(divisableBy) == 0
                        ? int.Parse(ifTrue)
                        : int.Parse(ifFalse);
                }
            }

            return 0;
        }

        private class Monkey
        {
            public Queue<int> Items { get; } = new();
            public Func<int, int>? Operation { get; set; }
            public Func<int, int>? Test { get; set; }
        }

        private Func<int, int> GetOperation(string left, string op, string right) =>
            (old) =>
            {
                var leftVal = left == "old" ? old : int.Parse(left);
                var rightVal = right == "old" ? old : int.Parse(right);
                return op switch
                {
                    "+" => leftVal + rightVal,
                    "-" => leftVal - rightVal,
                    "*" => leftVal * rightVal,
                    "/" or _ => leftVal / rightVal,
                };
            };

        public int? Process2(string[] inputs) => throw new NotImplementedException();
    }
}

