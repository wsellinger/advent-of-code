using AdventOfCode.Years;

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
        public void A_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
        {
            var actual = Year_2015.Day_01_A(input);
            Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(")", 1)]
		[InlineData("()())", 5)]
		public void B_Given_ValidInput_Returns_ExpectedResult(string input, long expected)
		{
			var actual = Year_2015.Day_01_B(input);
			Assert.Equal(expected, actual);
		}
	}
}