using AdventOfCode.Logic.Year2023;

namespace Year_2023
{
    public class Day_01
    {
        [Theory]
        [InlineData("1abc2", 12)]
        [InlineData("pqr3stu8vwx", 38)]
        [InlineData("a1b2c3d4e5f", 15)]
        [InlineData("treb7uchet", 77)]
        [InlineData("pqr3stu8vwx\r\na1b2c3d4e5f", 53)]
        [InlineData("1abc2\r\ntreb7uchet", 89)]
        [InlineData("1abc2\r\npqr3stu8vwx\r\na1b2c3d4e5f\r\ntreb7uchet", 142)]
        public void PartA(string input, long expected)
        {
            var actual = Day01.PartA(input);
            Assert.Equal(expected, actual);
		}
	}
}