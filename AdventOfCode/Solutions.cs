using AdventOfCode.Logic.Tools;
using AdventOfCode.Logic.Utils;

namespace AdventOfCode
{
    namespace Solutions
    {
        namespace Year2015
        {
            static class Day01
            {
                public static void PartA()
                {
                    string input = AocUtils.GetSingleLineInput(2015, 1);
                    long result = Logic.Year2015.Day01.PartA(input);
                    Console.WriteLine(result);
                }

                public static void PartB()
                {
                    string input = AocUtils.GetSingleLineInput(2015, 1);
                    long result = Logic.Year2015.Day01.PartB(input);
                    Console.WriteLine(result);
                }
            }

            static class Day02 
            { 
                public static async Task PartA() 
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(2015, 2);
                    long result = await Logic.Year2015.Day02.PartA(input);
                    Console.WriteLine(result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(2015, 2);
                    long result = await Logic.Year2015.Day02.PartB(input);
                    Console.WriteLine(result);
                }
            }
        }

        namespace Year2023
        {
            static class Day01
            {
                public static async Task PartA()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(2023, 1);
                    long result = await Logic.Year2023.Day01.PartA(input);
                    Console.WriteLine(result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(2023, 1);
                    long result = await Logic.Year2023.Day01.PartB(input);
                    Console.WriteLine(result);
                }
            }
            static class Day02
            {
                public static async Task PartA()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(2023, 2);
                    long result = await Logic.Year2023.Day02.PartA(input);
                    Console.WriteLine(result);
                }

                public static async Task PartB()
                {
                    using IStreamReader input = AocUtils.GetFileStreamInput(2023, 2);
                    long result = await Logic.Year2023.Day02.PartB(input);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
