using AdventOfCode.Logic.Exceptions;
using AdventOfCode.Logic.Tools;

namespace AdventOfCode.Logic.Utils
{
    public class AocUtils
    {
        public static string GetSingleLineInput(int year, int day)
        {
            string name = GetFileName(year, day);
            StreamReader sr = new(name);
            return sr.ReadLine() ?? throw new EmptyFileException();
        }

        public static IStreamReader GetFileStreamInput(int year, int day)
        {
            string name = GetFileName(year, day);
            return new FileStreamReader(name);
        }

        private static string GetFileName(int year, int day) =>
            $"Input/Year_{year}__Day_{day:D2}.txt";
    }
}
