using System;
namespace AdventOfCode2022
{
	public class Day3
	{
		public Day3()
		{
		}

		public int Process1(string[] inputs)
		{
			var prioritySum = 0;

			foreach (var input in inputs)
			{
				var compartment1 = input.Take(input.Length / 2);
				var compartment2 = input.TakeLast(input.Length / 2);

				// Common items
				var commonItem = compartment1.Intersect(compartment2).First();
				var priority = char.IsUpper(commonItem)
					? commonItem - 'A' + 27
					: commonItem - 'a' + 1;

				prioritySum += priority;
			}

			return prioritySum;
		}

		public int Process2(string[] inputs)
		{
			var prioritySum = 0;

			var groups = inputs.Chunk(3);

			foreach (var group in groups)
			{
				var commonChar = group[0].Intersect(group[1]).Intersect(group[2]).First();
                var priority = char.IsUpper(commonChar)
					? commonChar - 'A' + 27
					: commonChar - 'a' + 1;

                prioritySum += priority;
            }

			return prioritySum;
		}
	}
}

