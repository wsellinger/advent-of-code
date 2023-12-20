using AdventOfCode.Logic.Tools;

using Day = AdventOfCode.Logic.Year2023.Day03;

namespace Year_2023
{
    public class Day_03
    {
        [Theory]
        [InlineData("123", 0)]
        [InlineData(".123.", 0)]
        [InlineData("@123", 123)]
        [InlineData("123@", 123)]
        [InlineData("@....\r\n.123.", 123)]
        [InlineData(".@...\r\n.123.", 123)]
        [InlineData("....@\r\n.123.", 123)]
        [InlineData(".123.\r\n@....", 123)]
        [InlineData(".123.\r\n.@...", 123)]
        [InlineData(".123.\r\n....@", 123)]
        [InlineData("...*...\r\n.37.301\r\n.......", 338)]
        [InlineData(
            "467..114..\r\n" +
            "...*......\r\n" +
            "..35..633.\r\n" +
            "......#...\r\n" +
            "617*......\r\n" +
            ".....+.58.\r\n" +
            "..592.....\r\n" +
            "......755.\r\n" +
            "...$.*....\r\n" +
            ".664.598..", 4361)]
        public void PartA(string input, long expected)
        {
            var stream = new StringStreamReader(input);
            var actual = Day.PartA(stream).Result;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12*", 0)]
        [InlineData("12.*34", 0)]
        [InlineData("12*34", 408)]
        [InlineData(
            "...*...\r\n" +
            ".37.301\r\n" +
            ".......", 11137)]
        [InlineData(
            "467..114..\r\n" +
            "...*......\r\n" +
            "..35..633.\r\n" +
            "......#...\r\n" +
            "617*......\r\n" +
            ".....+.58.\r\n" +
            "..592.....\r\n" +
            "......755.\r\n" +
            "...$.*....\r\n" +
            ".664.598..", 467835)]
        public void PartB(string input, long expected)
        {
            var stream = new StringStreamReader(input);
            var actual = Day.PartB(stream).Result;
            Assert.Equal(expected, actual);
        }
    }
}