using System;
using System.Collections.Generic;

namespace AdventOfCode2022
{
    public class Day12 : IDay<int?>
    {
        public int? Process1(string[] inputs)
        {
            var heightMap = new int[inputs.Length][];
            var startingPosition = (0, 0);
            for (int row = 0; row < inputs.Length; row++)
            {
                heightMap[row] = new int[inputs[row].Length];
                for (int col = 0; col < inputs[row].Length; col++)
                {
                    var heightChar = inputs[row][col];
                    var height = 0;
                    if (heightChar == 'S')
                    {
                        height = 0;
                        startingPosition = (row, col);
                    }
                    else if (heightChar == 'E')
                    {
                        height = 26;
                    }
                    else
                    {
                        height = heightChar - 'a';
                    }
                    heightMap[row][col] = height;
                }
            }

            // Pathfinding
            var moves = new List<(int row, int col)>() { (startingPosition.Item1, startingPosition.Item2) };
            var shortestPath = this.PathFind(heightMap, startingPosition.Item1, startingPosition.Item2, moves)!;
            //Console.WriteLine(string.Join(',', shortestPath));
            return shortestPath.Count - 1;
        }

        private List<(int row, int col)>? PathFind(int[][] heightMap, int row, int col, List<(int row, int col)> previousMoves)
        {
            if (heightMap[row][col] == 26)
            {
                Console.WriteLine($"Found the end at {row},{col} with {previousMoves.Count} moves");
                // found the end, return this path as a success path
                return previousMoves;
            }

            var offsetOptions = new[]
            {
                (-1, 0),
                (1, 0),
                (0, 1),
                (0, -1)
            }
            .Select(offset => (row + offset.Item1, col + offset.Item2))
            .Where(coords => coords.Item1 >= 0 && coords.Item2 >= 0 && coords.Item1 < heightMap.Length && coords.Item2 < heightMap[coords.Item1].Length)
            .Select(coords => (coords.Item1, coords.Item2, heightMap[coords.Item1][coords.Item2]))
            .OrderByDescending(x => x.Item3);

            var paths = new List<List<(int row, int col)>>();

            foreach (var (newRow, newCol, newHeight) in offsetOptions)
            {
                if ((newHeight - 1) <= heightMap[row][col] && !previousMoves.Contains((newRow, newCol)))
                {
                    // Test the next step of this path
                    var moves = new List<(int row, int col)>(previousMoves);
                    moves.Add((newRow, newCol));
                    var newPath = this.PathFind(heightMap, newRow, newCol, moves);
                    if (newPath != null)
                    {
                        paths.Add(newPath);
                    }
                }
            }
            if (!paths.Any())
            {
                // no possible moves from here
                return null;
            }
            return paths.MinBy(x => x.Count)!;  
        }

        public int? Process2(string[] inputs) => throw new NotImplementedException();
    }
}

