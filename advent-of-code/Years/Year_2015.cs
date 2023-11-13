namespace AdventOfCode.Years
{
    public class Year_2015
    {
        public static long Day_01(string input)
        {
            long result = 0;

            foreach (var item in input)
            {
                if (item == '(')
                    result++;
                else if (item == ')')
                    result--;
            }

            return result;
        }
    }
}
