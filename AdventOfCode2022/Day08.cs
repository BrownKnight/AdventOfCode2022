using System;
namespace AdventOfCode2022
{
    public class Day08 : IDay<int?>
    {
        public Day08()
        {
        }

        public int? Process1(string[] inputs)
        {
            var grid = CreateGrid(inputs);

            // Matrix created, now find visible trees
            var visibleTrees = 0;
            for (int x = 0; x < grid.Length; x++)
            {
                for (int y = 0; y < grid[x].Length; y++)
                {
                    var isVisible = IsVisible(grid, x, y);
                    if (isVisible)
                    {
                        visibleTrees++;
                    }
                }
            }


            return visibleTrees;
        }

        private static int[][] CreateGrid(string[] inputs)
        {
            var grid = new int[inputs.Length][];

            for (int i = 0; i < inputs.Length; i++)
            {
                // create all the columns in this row
                grid[i] = new int[inputs[i].Length];
                for (int j = 0; j < inputs.Length; j++)
                {
                    grid[i][j] = int.Parse(inputs[i][j].ToString());
                }
            }

            return grid;
        }

        private static bool IsVisible(int[][] grid, int x, int y)
        {
            foreach (var direction in Enum.GetValues<Direction>())
            {
                if (IsVisibleInDirection(grid, x, y, grid[x][y], direction))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsVisibleInDirection(int[][] grid, int x, int y, int originalHeight, Direction direction)
        {
            var (offsetX, offsetY) = direction switch
            {
                Direction.Up => (-1, 0),
                Direction.Down => (1, 0),
                Direction.Left => (0, -1),
                Direction.Right or _ => (0, 1)
            };

            var newX = x + offsetX;
            var newY = y + offsetY;

            if (newX < 0 || newX >= grid.Length
                || newY < 0 || newY >= grid[x].Length)
            {
                return true;
            }

            var positionToCheck = grid[newX][newY];
            var isVisible = positionToCheck < originalHeight;
            if (isVisible)
            {
                return IsVisibleInDirection(grid, newX, newY, originalHeight, direction);
            }
            else
            {
                return false;
            }
        }

        private enum Direction
        {
            Up,
            Right,
            Down,
            Left
        }

        public int? Process2(string[] inputs)
        {
            var grid = CreateGrid(inputs);

            var scenicScores = new List<int>();
            for (int x = 0; x < grid.Length; x++)
            {
                for (int y = 0; y < grid[x].Length; y++)
                {
                    var visibleTrees = CountVisibleTrees(grid, x, y);
                    scenicScores.Add(visibleTrees);
                }
            }

            return scenicScores.Max();
        }

        private static int CountVisibleTrees(int[][] grid, int x, int y)
        {
            return Enum
                .GetValues<Direction>()
                .Select(direction => CountVisibleTreesInDirection(grid, x, y, grid[x][y], direction))
                .Aggregate((current, acc) => current * acc);
        }

        private static int CountVisibleTreesInDirection(int[][] grid, int x, int y, int original, Direction direction)
        {
            var (offsetX, offsetY) = direction switch
            {
                Direction.Up => (-1, 0),
                Direction.Down => (1, 0),
                Direction.Left => (0, -1),
                Direction.Right or _ => (0, 1)
            };

            var scenicScore = 0;

            var newX = x + offsetX;
            var newY = y + offsetY;
            while (newX >= 0 && newX < grid.Length
                && newY >= 0 && newY < grid[x].Length)
            {
                var newValue = grid[newX][newY];
                if (newValue < original)
                {
                    scenicScore++;
                }
                else if (newValue >= original)
                {
                    scenicScore++;
                    // Cant see any trees beyond any tree higher than original
                    break;
                }

                newX += offsetX;
                newY += offsetY;
            }

            return scenicScore;
        }
    }
}

