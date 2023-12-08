using AdventOfCode.Logic.Tools;
using AdventOfCode.Logic.Year2015;

namespace Year_2015
{
    public class Day_02
	{
		[Theory]
		[InlineData("2x3x4", 58)]
		[InlineData("1x1x10", 43)]
		[InlineData("2x3x4\r\n1x1x10\r\n", 101)]
		public void PartA(string input, long expected)
        {
            var stream = new StringStreamReader(input);
            var actual = Day02.PartA(stream).Result;
            Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("2x3x4", 34)]
		[InlineData("1x1x10", 14)]
		[InlineData("2x3x4\r\n1x1x10\r\n", 48)]
		public void PartB(string input, long expected)
        {
            var stream = new StringStreamReader(input);
            var actual = Day02.PartB(stream).Result;
			Assert.Equal(expected, actual);
		}
	}
}
