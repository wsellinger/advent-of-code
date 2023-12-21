using AdventOfCode.Logic.Tools;
using AdventOfCode.Logic.Utils;

namespace AdventOfCode.Logic.Year2023
{
    /// <summary>
    /// --- Day 3: Gear Ratios ---
    ///
    ///    You and the Elf eventually reach a gondola lift station; he says the gondola lift will take you up to the water source, but this 
    ///    is as far as he can bring you. You go inside.
    ///    
    ///    It doesn't take long to find the gondolas, but there seems to be a problem: they're not moving.
    ///    
    ///    "Aaah!"
    ///
    ///    You turn around to see a slightly-greasy Elf with a wrench and a look of surprise. "Sorry, I wasn't expecting anyone! The 
    ///    gondola lift isn't working right now; it'll still be a while before I can fix it." You offer to help.
    ///
    ///    The engineer explains that an engine part seems to be missing from the engine, but nobody can figure out which one. If you can 
    ///    add up all the part numbers in the engine schematic, it should be easy to work out which part is missing.
    ///
    ///    The engine schematic (your puzzle input) consists of a visual representation of the engine. There are lots of numbers and 
    ///    symbols you don't really understand, but apparently any number adjacent to a symbol, even diagonally, is a "part number" and 
    ///    should be included in your sum. (Periods (.) do not count as a symbol.)
    ///
    ///    Here is an example engine schematic:
    ///
    ///    467..114..
    ///    ...*......
    ///    ..35..633.
    ///    ......#...
    ///    617*......
    ///    .....+.58.
    ///    ..592.....
    ///    ......755.
    ///    ...$.*....
    ///    .664.598..
    ///
    ///    In this schematic, two numbers are not part numbers because they are not adjacent to a symbol: 114 (top right) and 58 (middle 
    ///    right). Every other number is adjacent to a symbol and so is a part number; their sum is 4361.
    ///    
    ///    Of course, the actual engine schematic is much larger. What is the sum of all of the part numbers in the engine schematic?
    ///    
    ///    --- Part Two ---
    ///    
    ///    The engineer finds the missing part and installs it in the engine! As the engine springs to life, you jump in the closest 
    ///    gondola, finally ready to ascend to the water source.
    ///    
    ///    You don't seem to be going very fast, though. Maybe something is still wrong? Fortunately, the gondola has a phone labeled 
    ///    "help", so you pick it up and the engineer answers.
    ///    
    ///    Before you can explain the situation, she suggests that you look out the window. There stands the engineer, holding a phone in 
    ///    one hand and waving with the other. You're going so slowly that you haven't even left the station. You exit the gondola.
    ///    
    ///    The missing part wasn't the only issue - one of the gears in the engine is wrong. A gear is any * symbol that is adjacent to 
    ///    exactly two part numbers. Its gear ratio is the result of multiplying those two numbers together.
    ///    
    ///    This time, you need to find the gear ratio of every gear and add them all up so that the engineer can figure out which gear 
    ///    needs to be replaced.
    ///    
    ///    Consider the same engine schematic again:
    ///
    ///    467..114..
    ///    ...*......
    ///    ..35..633.
    ///    ......#...
    ///    617*......
    ///    .....+.58.
    ///    ..592.....
    ///    ......755.
    ///    ...$.*....
    ///    .664.598..
    /// 
    ///    In this schematic, there are two gears. The first is in the top left; it has part numbers 467 and 35, so its gear ratio is 
    ///    16345.The second gear is in the lower right; its gear ratio is 451490. (The * adjacent to 617 is not a gear because it is only 
    ///    adjacent to one part number.) Adding up all of the gear ratios produces 467835.
    ///
    ///    What is the sum of all of the gear ratios in your engine schematic ?
    ///
    /// </summary>
    public class Day03
    {
        public static async Task<long> PartA(IStreamReader input)
        {
            List<int> partNumbers = [];
            SchematicParser parser = await SchematicParser.Create(input);
            
            while (await parser.Advance())
                while (parser.GetNextPartNumber(out int partNumber))
                    partNumbers.Add(partNumber);

            return partNumbers.Sum();
        }

        public static async Task<long> PartB(IStreamReader input)
        {
            List<int> gearRatios = [];
            SchematicParser parser = await SchematicParser.Create(input);

            while (await parser.Advance())
                while (parser.GetNextGearRatio(out int gearRatio))
                    gearRatios.Add(gearRatio);

            return gearRatios.Sum();
        }

        //Private
        private class SchematicParser(IStreamReader input) : LineSet(input)
        {
            private const char EMPTY = '.';
            private const char GEAR = '*';

            private int _index = 0;

            public bool GetNextPartNumber(out int partNumber)
            {
                partNumber = 0;

                if (Current is null)
                    return false;

                while (GetNextNumberRange(out Range range))
                {
                    if (ValidateNumberRange(range))
                    {
                        partNumber = Current[range].ToInt();
                        return true;
                    }
                }

                return false;

                //Local

                bool GetNextNumberRange(out Range range)
                {
                    int? iStart = null;
                    for (; _index < Current?.Length; _index++)
                    {                        
                        if (Current[_index].IsDigit()) //start of digits
                        {
                            iStart ??= _index;
                        }
                        else if (iStart is not null) //end of digits 
                        {
                            range = new(iStart.Value, _index);
                            return true;
                        }
                    }

                    if (iStart is not null) //number at end of line
                    {
                        range = new(iStart.Value, _index);
                        return true;
                    }

                    _index = 0;
                    range = new();

                    return false;
                }

                bool ValidateNumberRange(Range range)
                {
                    int iStart = range.Start.Value - 1;
                    if (IsValid(iStart, Current))
                        return true;

                    int iEnd = range.End.Value;
                    if (IsValid(iEnd, Current))
                        return true;

                    for (int i = iStart; i <= iEnd; i++)
                        if (IsValid(i, Previous) || IsValid(i, Next))
                            return true;

                    return false;

                    //Local
                    static bool IsValid(int i, string? s) =>
                        IsInRange(i, s) && IsSymbol(s![i]);

                    static bool IsSymbol(char ch) =>
                        ch != EMPTY && !ch.IsDigit();
                }
            }

            public bool GetNextGearRatio(out int gearRatio)
            {
                gearRatio = 0;

                if (Current is null)
                    return false;

                while (GetNextGearIndex(out int iGear))
                    if (GetGearRatio(iGear, out gearRatio))
                        return true;

                return false;

                //Local

                bool GetNextGearIndex(out int iGear)
                {
                    for (; _index < Current?.Length; _index++)
                    {
                        if (Current[_index] == GEAR)
                        {
                            iGear = _index++; //increment index post assignment to start after it next time
                            return true;
                        }
                    }

                    _index = 0;
                    iGear = 0;

                    return false;
                }

                bool GetGearRatio(int iGear, out int gearRatio)
                {
                    List<int> partNumbers = [];
                    gearRatio = 0;

                    int iStart = iGear - 1;
                    if (IsDigit(iStart, Current))
                        partNumbers.Add(GetPartNumber(iStart, Current));

                    int iEnd = iGear + 1;
                    if (IsDigit(iEnd, Current))
                        partNumbers.Add(GetPartNumber(iEnd, Current));

                    for (int i = iStart; i <= iEnd && partNumbers.Count < 2; i++)
                        if (IsDigit(i, Previous))
                            partNumbers.Add(
                                GetPartNumberAndUpdateIndex(ref i, Previous));

                    for (int i = iStart; i <= iEnd && partNumbers.Count < 2; i++)
                        if (IsDigit(i, Next))
                            partNumbers.Add(
                                GetPartNumberAndUpdateIndex(ref i, Next));

                    if (partNumbers.Count < 2)
                        return false;

                    gearRatio = partNumbers.Aggregate((acc, x) => acc * x);
                    
                    return true;
                    
                    //Local

                    static int GetPartNumber(int i, string? s) =>
                        GetPartNumberAndUpdateIndex(ref i, s);

                    static int GetPartNumberAndUpdateIndex(ref int i, string? s)
                    {
                        if (s == null) 
                            return 0;

                        int iLeft = GetLeft(i, s);
                        int iRight = GetRight(i, s);

                        i = iRight; //update index to end of this number
                        return s[iLeft..iRight].ToInt();

                        //Local

                        static int GetLeft(int i, string s)
                        {
                            for (--i; i >= 0; i--)
                                if (!s[i].IsDigit())
                                    break;

                            return ++i; //Left Inclusive
                        }

                        static int GetRight(int i, string s)
                        {
                            for (++i; i < s.Length; i++)
                                if (!s[i].IsDigit())
                                    break;

                            return i; //Right Exclusive
                        }
                    }

                    static bool IsDigit(int i, string? s) =>
                        IsInRange(i, s) && s![i].IsDigit();
                }
            }

            private static bool IsInRange(int i, string? s) =>
                s is not null && i >= 0 && i < s.Length;

            public async static Task<SchematicParser> Create(IStreamReader input)
            {
                SchematicParser schematicParser = new(input);
                await schematicParser.Init();

                return schematicParser;
            }
        }

        private class LineSet(IStreamReader input)
        {
            protected string? Previous { get; private set; }
            protected string? Current { get; private set; }
            protected string? Next { get; private set; }

            public async Task Init() => 
                Next = await input.ReadLineAsync();

            public async Task<bool> Advance()
            {
                Previous = Current;
                Current = Next;
                Next = await input.ReadLineAsync();

                return Current is not null;
            }
        }
    }
}
