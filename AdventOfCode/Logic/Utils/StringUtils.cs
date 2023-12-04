namespace AdventOfCode.Logic.Utils
{
    public static class StringUtils
    {
        public static IEnumerable<string> SplitOnNewline(this string str) => 
            str.EndsWith(Environment.NewLine) ? 
            str.Split(Environment.NewLine).SkipLast(1) : 
            str.Split(Environment.NewLine);

        public static bool IsEmpty(this string str) => str == string.Empty;
        public static int ToInt(this string str) => int.Parse(str);

        public static bool IsDigit(this char ch) => char.IsDigit(ch);
    }
}
