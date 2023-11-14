using AdventOfCode.Year_2015;

namespace UnitTests.Year_2015_Tests
{
	public class Day_02_Tests
	{
		[Theory]
		[InlineData("2x3x4", 58)]
		[InlineData("1x1x10", 43)]
		[InlineData("2x3x4\r\n1x1x10\r\n", 101)]
		public void PuzzleA_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
		{
			var actual = Day_02.PuzzleA(input);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("2x3x4", 34)]
		[InlineData("1x1x10", 14)]
		[InlineData("2x3x4\r\n1x1x10\r\n", 48)]
		public void PuzzleB_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
		{
			var actual = Day_02.PuzzleB(input);
			Assert.Equal(expected, actual);
		}
	}
}
