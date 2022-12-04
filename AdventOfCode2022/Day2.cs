using System;
namespace AdventOfCode2022
{
	public class Day2 : IDay
	{
		public Day2()
		{
		}

		public int Process1(string[] inputs)
		{
			var player1Score = 0;
			var player2Score = 0;

			foreach (var input in inputs)
			{
				var p1 = input[0];
				var p2 = input[2];
				var p1Score = p1 - 'A' + 1;
				var p2Score = p2 - 'X' + 1;

				// If it's a draw
				if (p1Score == p2Score)
				{
					p1Score += 3;
					p2Score += 3;
				}
				else
				{
					_ = (p1, p2) switch
					{
						('B', 'X') or
						('C', 'Y') or
						('A', 'Z') => p1Score += 6,
						_ => p2Score += 6
					};
				}

				player1Score += p1Score;
				player2Score += p2Score;
			}

			return player2Score;
		}

		public int Process2(string[] inputs)
		{
			var player2Score = 0;

			foreach (var input in inputs)
			{
				var p1 = input[0];
				var intendedOutcome = input[2];

				// Draw +3
				if (intendedOutcome == 'Y')
				{
					player2Score += 3;
				}
				else if (intendedOutcome == 'Z')
				{
					// Win +6
					player2Score += 6;
				}

				var p2Play = (p1, intendedOutcome) switch
				{
					('A', 'X') => 'C',
					('A', 'Y') => 'A',
					('A', 'Z') => 'B',
					('B', 'X') => 'A',
					('B', 'Y') => 'B',
					('B', 'Z') => 'C',
					('C', 'X') => 'B',
					('C', 'Y') => 'C',
					('C', 'Z') => 'A',
					_ => throw new InvalidOperationException("Unknwon play")
				};

				player2Score += p2Play - 'A' + 1;
			}

			return player2Score;
		}
	}
}

