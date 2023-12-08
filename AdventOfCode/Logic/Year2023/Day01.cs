using AdventOfCode.Logic.Tools;
using AdventOfCode.Logic.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventOfCode.Logic.Year2023
{
    /// <summary>
    /// --- Day 1: Trebuchet?! ---
    ///
    /// Something is wrong with global snow production, and you've been selected to take a look. The Elves have even given you a map; on it, 
    /// they've used stars to mark the top fifty locations that are likely to be having problems.
    /// 
    /// You've been doing this long enough to know that to restore snow operations, you need to check all fifty stars by December 25th.
    /// 
    /// Collect stars by solving puzzles.Two puzzles will be made available on each day in the Advent calendar; the second puzzle is 
    /// unlocked when you complete the first.Each puzzle grants one star. Good luck!
    /// 
    /// You try to ask why they can't just use a weather machine ("not powerful enough") and where they're even sending you ("the sky") and 
    /// why your map looks mostly blank("you sure ask a lot of questions") and hang on did you just say the sky("of course, where do you 
    /// think snow comes from") when you realize that the Elves are already loading you into a trebuchet ("please hold still, we need to 
    /// strap you in").
    /// 
    /// As they're making the final adjustments, they discover that their calibration document (your puzzle input) has been amended by a 
    /// very young Elf who was apparently just excited to show off her art skills. Consequently, the Elves are having trouble reading the 
    /// values on the document.
    /// 
    /// The newly-improved calibration document consists of lines of text; each line originally contained a specific calibration value that 
    /// the Elves now need to recover.On each line, the calibration value can be found by combining the first digit and the last digit (in 
    /// that order) to form a single two-digit number.
    ///     For example:
    /// 
    /// 1abc2
    ///     pqr3stu8vwx
    /// a1b2c3d4e5f
    ///     treb7uchet
    /// 
    /// In this example, the calibration values of these four lines are 12, 38, 15, and 77. Adding these together produces 142.
    /// 
    /// Consider your entire calibration document.What is the sum of all of the calibration values?
    /// 
    /// --- Part Two ---
    ///
    ///     Your calculation isn't quite right. It looks like some of the digits are actually spelled out with letters: one, two, three, four, five, six, seven, eight, and nine also count as valid "digits".
    /// 
    /// Equipped with this new information, you now need to find the real first and last digit on each line.For example:
    /// 
    /// two1nine
    /// eightwothree
    /// abcone2threexyz
    /// xtwone3four
    /// 4nineeightseven2
    /// zoneight234
    /// 7pqrstsixteen
    /// 
    /// In this example, the calibration values are 29, 83, 13, 24, 42, 14, and 76. Adding these together produces 281.
    /// 
    /// What is the sum of all of the calibration values?
    /// 
    /// </summary>
    public class Day01
    {
        public static async Task<long> PartA(IStreamReader input)
        {
            List<int> calibrationList = [];
            string? line;
            while ((line = await input.ReadLineAsync()) is not null)
            {
                int value = GetCalibrationValue(line);
                calibrationList.Add(value);
            }
            return calibrationList.Sum();

            //Local Methods

            static int GetCalibrationValue(string input) 
            {
                char firstDigit = input.First(x => char.IsDigit(x));
                char lastDigit = input.Last(x => char.IsDigit(x));

                return ConvertDigitsToInt(firstDigit, lastDigit);
            }
        }

        public static async Task<long> PartB(IStreamReader input)
        {
            string? line;
            List<int> calibrationList = [];
            while ((line = await input.ReadLineAsync()) is not null)
            {
                int value = GetCalibrationValue(line);
                calibrationList.Add(value);
            }

            return calibrationList.Sum();

            //Local Methods

            static int GetCalibrationValue(string input)
            {
                char firstDigit = GetFirstDigit(input);
                char lastDigit = GetLastDigit(input);

                return ConvertDigitsToInt(firstDigit, lastDigit);
            }

            static char GetFirstDigit(string input)
            {
                for (int i = 0; i < input.Length; i++)
                    if (GetDigitAtIndex(input, i, out char digit))
                        return digit;

                throw new Exception("No Digit Found In Line");
            }

            static char GetLastDigit(string input)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                    if (GetDigitAtIndex(input, i, out char digit))
                        return digit;

                throw new Exception("No Digit Found In Line");
            }

            static bool GetDigitAtIndex(string input, int index, out char digit)
            {
                if (input[index].IsDigit())
                {
                    digit = input[index];
                    return true;
                }
                else
                {
                    for (int i = 0; i < DigitWords.Length; i++)
                    {
                        string word = DigitWords[i];
                        int iWordEnd = index + word.Length;
                        if (iWordEnd <= input.Length)
                        {
                            if (word == input[index..iWordEnd])
                            {
                                digit = (char)(i + 1 + '0');
                                return true;
                            }
                        }
                    }
                }

                digit = '\0';
                return false;
            }

        }

        private static int ConvertDigitsToInt(char firstDigit, char lastDigit) => 
            $"{firstDigit}{lastDigit}".ToInt();

        private static ImmutableArray<string> DigitWords => 
            ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
    }
}
