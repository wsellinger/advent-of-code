using AdventOfCode.Logic.Tools;
using AdventOfCode.Logic.Year2023;

namespace Year_2023
{
    public class Day_03
    {
        [Theory]
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
        [InlineData(
            "...*...\r\n" +
            ".37.301\r\n" +
            ".......", 338)]
        public void PartA(string input, long expected)
        {
            var stream = new StringStreamReader(input);
            var actual = Day03.PartA(stream).Result;
            Assert.Equal(expected, actual);
        }

        [Theory]
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
        [InlineData(
            "...*...\r\n" +
            ".37.301\r\n" +
            ".......", 11137)]
        public void PartB(string input, long expected)
        {
            var stream = new StringStreamReader(input);
            var actual = Day03.PartB(stream).Result;
            Assert.Equal(expected, actual);
        }
    }
}