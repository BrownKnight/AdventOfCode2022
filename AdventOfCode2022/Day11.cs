using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2022
{
    public class Day11 : IDay<long?>
    {
        public Day11()
        {
        }

        public long? Process1(string[] inputs)
        {
            var monkeys = GetMonkeysFromInput(inputs);

            for (int round = 0; round < 20; round++)
            {
                foreach (var monkey in monkeys)
                {
                    while (monkey.Items.Any())
                    {
                        monkey.Inspections++;
                        var itemWorryLevel = monkey.Items.Dequeue();
                        // rumn the operation on the item
                        itemWorryLevel = monkey.Operation!(itemWorryLevel);
                        itemWorryLevel = itemWorryLevel / 3;
                        var newMonkeyNumber = monkey.Test!(itemWorryLevel);

                        monkeys[newMonkeyNumber].Items.Enqueue(itemWorryLevel);
                    }
                }
            }
            var monkeyInspections = monkeys.Select(x => x.Inspections);

            return monkeyInspections.OrderDescending().ElementAt(0) * monkeyInspections.OrderDescending().ElementAt(1);
        }

        private List<Monkey> GetMonkeysFromInput(string[] inputs)
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

            return monkeys;
        }

        private class Monkey
        {
            public Queue<int> Items { get; } = new();
            public Func<int, int>? Operation { get; set; }
            public Func<int, int>? Test { get; set; }
            public long Inspections { get; set; }
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

        public long? Process2(string[] inputs)
        {
            var monkeys = GetMonkeysFromInput(inputs);

            for (int round = 0; round < 20; round++)
            {
                foreach (var monkey in monkeys)
                {
                    while (monkey.Items.Any())
                    {
                        monkey.Inspections++;
                        var itemWorryLevel = monkey.Items.Dequeue();
                        // rumn the operation on the item
                        itemWorryLevel = monkey.Operation!(itemWorryLevel);
                        var newMonkeyNumber = monkey.Test!(itemWorryLevel);

                        monkeys[newMonkeyNumber].Items.Enqueue(itemWorryLevel);
                    }
                }
            }
            var monkeyInspections = monkeys.Select(x => x.Inspections);

            return monkeyInspections.OrderDescending().ElementAt(0) * monkeyInspections.OrderDescending().ElementAt(1);
        }
    }
}

