using AdventOfCode.Year_2015;

namespace UnitTests.Year_2015_Tests
{
	public class Day_02_Tests
	{
		[Theory]
		[InlineData("2x3x4", 58)]
		[InlineData("1x1x10", 43)]
		public void PuzzleA_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
		{
			var actual = Day_02.PuzzleA(input);
			Assert.Equal(expected, actual);
		}
	}
}
