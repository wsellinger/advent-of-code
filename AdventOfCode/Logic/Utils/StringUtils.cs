namespace AdventOfCode.Logic.Utils
{
    public static class StringUtils
    {
        public static IEnumerable<string> SplitInputOnNewLine(this string str)
        {
            var split = str.SplitOnNewline();
            return split.Length > 0 && split[^1].IsEmpty() ? split.SkipLast(1) : split;
        }
        public static string[] SplitOnNewline(this string str) => str.Split("\r\n");
        public static bool IsEmpty(this string str) => str == string.Empty;
        public static int ToInt(this string str) => int.Parse(str);

        public static bool IsDigit(this char ch) => char.IsDigit(ch);
    }
}
