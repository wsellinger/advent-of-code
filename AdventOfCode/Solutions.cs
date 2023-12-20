using AdventOfCode.Logic.Tools;
using AdventOfCode.Logic.Utils;

namespace AdventOfCode
{
    namespace Solutions
    {
        namespace Year2015
        {
            using static AdventOfCode.Solutions.Year2015.Shared;

            internal struct Shared { public static int Year => 2015; }

            static class Day01
            {
                public static int Day => 1;

                public static void PartA()
                {
                    string input = AocUtils.GetSingleLineInput(Year, Day);
                    long result = Logic.Year2015.Day01.PartA(input);
                    AocUtils.LogResult(Year, Day, 'A', result);
                }

                public static void PartB()
                {
                    string input = AocUtils.GetSingleLineInput(Year, Day);
                    long result = Logic.Year2015.Day01.PartB(input);
                    AocUtils.LogResult(Year, Day, 'B', result);
                }
            }

            static class Day02
            {
                public static int Day => 2;

                public static async Task PartA() 
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2015.Day02.PartA(input);
                    AocUtils.LogResult(Year, Day, 'A', result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2015.Day02.PartB(input);
                    AocUtils.LogResult(Year, Day, 'B', result);
                }
            }
        }

        namespace Year2023
        {
            using static AdventOfCode.Solutions.Year2023.Shared;

            internal struct Shared { public static int Year => 2023; }

            static class Day01
            {
                public static int Day => 1;

                public static async Task PartA()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day01.PartA(input);
                    AocUtils.LogResult(Year, Day, 'A', result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day01.PartB(input);
                    AocUtils.LogResult(Year, Day, 'B', result);
                }
            }

            static class Day02
            {
                public static int Day => 2;

                public static async Task PartA()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day02.PartA(input);
                    AocUtils.LogResult(Year, Day, 'A', result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day02.PartB(input);
                    AocUtils.LogResult(Year, Day, 'B', result);
                }
            }

            static class Day03
            {
                public static int Day => 3;

                public static async Task PartA()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day03.PartA(input);
                    AocUtils.LogResult(Year, Day, 'A', result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day03.PartB(input);
                    AocUtils.LogResult(Year, Day, 'B', result);
                }
            }

            static class Day04
            {
                public static int Day => 4;

                public static async Task PartA()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day04.PartA(input);
                    AocUtils.LogResult(Year, Day, 'A', result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(Year, Day);
                    long result = await Logic.Year2023.Day04.PartB(input);
                    AocUtils.LogResult(Year, Day, 'B', result);
                }
            }
        }
    }
}
