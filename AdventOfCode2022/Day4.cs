using System;
namespace AdventOfCode2022
{
	public class Day4
	{
		public Day4()
		{
		}

		public int Process1(string[] inputs)
		{
			var fullyContainedCount = 0;

			foreach (var input in inputs)
			{
				var indexes = input.Split(',').SelectMany(x => x.Split('-')).Select(int.Parse).ToArray();
				var (pair1L, pair1R) = (indexes[0], indexes[1]);
				var (pair2L, pair2R) = (indexes[2], indexes[3]);

				// is pair 1 inside pair 2
				if (pair1L >= pair2L && pair1R <= pair2R)
				{
					fullyContainedCount++;
				}
				else if (pair2L >= pair1L && pair2R <= pair1R)
				{
					fullyContainedCount++;
				}
			}

			return fullyContainedCount;
		}

		public int Process2(string[] inputs)
		{
            var overlaps = 0;

            foreach (var input in inputs)
            {
                var indexes = input.Split(',').SelectMany(x => x.Split('-')).Select(int.Parse).ToArray();
                var (pair1L, pair1R) = (indexes[0], indexes[1]);
                var (pair2L, pair2R) = (indexes[2], indexes[3]);

                // is pair 1 inside pair 2
                if ((pair1L >= pair2L && pair1L <= pair2R)
					|| (pair1R <= pair2R && pair1R >= pair2L))
                {
                    overlaps++;
                }
                else if ((pair2L >= pair1L && pair2L <= pair1R)
                    || (pair2R <= pair1R && pair2R >= pair1L))
                {
                    overlaps++;
                }
            }

            return overlaps;
        }
    }
}

