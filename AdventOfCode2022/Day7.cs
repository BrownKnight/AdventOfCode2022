using System;
namespace AdventOfCode2022
{
    public class Day7 : IDay<int?>
    {
        public Day7()
        {
        }

        public int? Process1(string[] inputs)
        {
            var root = CreateTree(inputs);

            // Calculate sizes of the directories
            return SumSizesRecursively(root);
        }

        private static Directory CreateTree(string[] inputs)
        {
            var root = new Directory(null!, "/");
            var currentNode = root;

            // Create tree
            var i = 1;
            while (i < inputs.Length)
            {
                var command = inputs[i][2..];
                if (command.StartsWith("cd", StringComparison.InvariantCulture))
                {
                    var newName = command[3..];
                    currentNode = currentNode.Traverse(newName);
                    i++;
                }
                else if (command == "ls")
                {
                    i++;
                    while (i < inputs.Length && !inputs[i].StartsWith("$", StringComparison.InvariantCulture))
                    {
                        if (inputs[i].StartsWith("dir", StringComparison.InvariantCulture))
                        {
                            // Add a new directory
                            currentNode.Files.Add(new Directory(currentNode, inputs[i][4..]));
                        }
                        else
                        {
                            var split = inputs[i].Split(" ");
                            var size = int.Parse(split[0]);
                            currentNode.Files.Add(new File(currentNode, split[1], size));
                        }
                        i++;
                    }
                }
            }

            return root;
        }

        private int SumSizesRecursively(Directory dir)
        {
            var sum = 0;
            // Calculate sizes of all child directories
            foreach (var item in dir.Files.OfType<Directory>())
            {
                sum += SumSizesRecursively(item);
            }

            if (dir.Size <= 100000)
            {
                sum += dir.Size;
            }

            return sum;
        }

        public int? Process2(string[] inputs)
        {
            var root = CreateTree(inputs);

            var totalSize = 70000000;
            var desiredFreeSpace = 30000000;
            var actualFreeSpace = totalSize - root.Size;
            var spaceToFree = desiredFreeSpace - actualFreeSpace;

            return GetSmallestDirSizeAboveX(root, root.Size, spaceToFree);
        }

        private int GetSmallestDirSizeAboveX(Directory dir, int current, int target)
        {
            var items = dir.Files.OfType<Directory>();
            foreach (var item in items)
            {
                var size = item.Size;
                if (size < current && size > target)
                {
                    current = size;
                }

                current = GetSmallestDirSizeAboveX(item, current, target);
            }

            return current;
        }

        private interface IItem
        {
            public int Size { get; }
            public string Name { get; }
            public IItem Parent { get; }
        }

        private record Directory(IItem Parent, string Name) : IItem
        {
            public int Size => Files.Sum(x => x.Size);

            public List<IItem> Files { get; } = new();

            public Directory Traverse(string name) =>
                name switch
                {
                    ".." => (Directory)Parent,
                    _ => (Directory)Files.First(x => x.Name == name)
                };
                
        }

        private record File(IItem Parent, string Name, int Size) : IItem;
    }
}

