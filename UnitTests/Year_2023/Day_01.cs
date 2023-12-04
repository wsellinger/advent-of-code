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

        [Theory]
        [InlineData("two1nine", 29)]
        [InlineData("eightwothree", 83)]
        [InlineData("abcone2threexyz", 13)]
        [InlineData("xtwone3four", 24)]
        [InlineData("4nineeightseven2", 42)]
        [InlineData("zoneight234", 14)]
        [InlineData("7pqrstsixteen", 76)]
        [InlineData("two1nine\r\nzoneight234", 43)]
        [InlineData("two1nine\r\neightwothree\r\nabcone2threexyz\r\nxtwone3four\r\n4nineeightseven2\r\nzoneight234\r\n7pqrstsixteen", 281)]
        public void PartB(string input, long expected)
        {
            var actual = Day01.PartB(input);
            Assert.Equal(expected, actual);
        }
    }
}