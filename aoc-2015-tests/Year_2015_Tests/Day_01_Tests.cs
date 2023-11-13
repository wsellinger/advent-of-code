using AdventOfCode.Year_2015;

namespace UnitTests.Year_2015_Tests
{
    public class Day_01_Tests
    {
        [Theory]
        [InlineData("(())", 0)]
        [InlineData("()()", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("))(((((", 3)]
        [InlineData("())", -1)]
        [InlineData("))(", -1)]
        [InlineData(")))", -3)]
        [InlineData(")())())", -3)]
        public void PuzzleA_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
        {
            var actual = Day_01.PuzzleA(input);
            Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(")", 1)]
		[InlineData("()())", 5)]
		public void PuzzleB_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
		{
			var actual = Day_01.PuzzleB(input);
			Assert.Equal(expected, actual);
		}
	}
}