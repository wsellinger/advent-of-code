using AdventOfCode.Logic.Year2015;

namespace Year_2015
{
    public class Day_01
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
        public void PartA(string input, long expected)
        {
            var actual = Day01.PartA(input);
            Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(")", 1)]
		[InlineData("()())", 5)]
		public void PartB(string input, long expected)
		{
			var actual = Day01.PartB(input);
			Assert.Equal(expected, actual);
		}
	}
}