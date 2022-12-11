using System;
namespace AdventOfCode2022
{
    public class Day09 : IDay<int?>
    {
        public Day09()
        {
        }

        public int? Process1(string[] inputs)
        {
            var head = (x: 0, y: 0);
            var tail = (x: 0, y: 0);
            var tailPositions = new List<(int x, int y)> { tail };

            var instructions = new List<string>();
            foreach (var input in inputs)
            {
                var direction = input[0];
                var count = int.Parse(input[2..]);

                instructions.AddRange(Enumerable.Range(0, count).Select(_ => direction.ToString()));
            }

            foreach (var instruction in instructions)
            {
                // Move the head
                head = instruction switch
                {
                    "R" => (head.x + 1, head.y),
                    "L" => (head.x - 1, head.y),
                    "U" => (head.x, head.y + 1),
                    "D" or _ => (head.x, head.y - 1)
                };

                // Move the tail closer to the head
                tail = MoveTailToHead(head, tail);
                tailPositions.Add(tail);
            }

            return tailPositions.Distinct().Count();
        }

        private static (int x, int y) MoveTailToHead((int x, int y) head, (int x, int y) tail)
        {
            // head and tail are overlapping, so they remain
            if (head == tail)
            {
                return tail;
            }

            // if it's adjacent, don't move
            var diffX = Math.Abs(head.x - tail.x);
            var diffY = Math.Abs(head.y - tail.y);
            if (diffX <= 1 && diffY <= 1)
            {
                return tail;
            }

            var newX = head.x < tail.x
                ? tail.x - 1
                : head.x > tail.x
                    ? tail.x + 1
                    : tail.x;

            var newY = head.y < tail.y
                ? tail.y - 1
                : head.y > tail.y
                    ? tail.y + 1
                    : tail.y;

            return (newX, newY);
        }

        public int? Process2(string[] inputs)
        {
            var knots = Enumerable.Range(0, 10).Select(_ => (x: 0, y: 0)).ToArray();
            var tailPositions = new List<(int x, int y)> { knots.Last() };

            var instructions = new List<string>();
            foreach (var input in inputs)
            {
                var direction = input[0];
                var count = int.Parse(input[2..]);

                instructions.AddRange(Enumerable.Range(0, count).Select(_ => direction.ToString()));
            }

            foreach (var instruction in instructions)
            {
                knots[0] = instruction switch
                {
                    "R" => (knots[0].x + 1, knots[0].y),
                    "L" => (knots[0].x - 1, knots[0].y),
                    "U" => (knots[0].x, knots[0].y + 1),
                    "D" or _ => (knots[0].x, knots[0].y - 1)
                };

                // Move all the knots in the rope
                for (int i = 1; i < knots.Length; i++)
                {
                    knots[i] = MoveTailToHead(knots[i - 1], knots[i]);
                }

                // Move the tail closer to the head
                tailPositions.Add(knots.Last());
            }

            return tailPositions.Distinct().Count();
        }
    }
}

