namespace AdventOfCode.Logic.Tools
{
    public class StringStreamReader(string value) : IStreamReader
    {
        public string Line { get; private set; } = string.Empty;

        private string Value { get; init; } = value;
        private int StartIndex { get; set; } = 0;

        public async Task<bool> ReadLineAsync()
        {
            bool result = false;

            if (StartIndex != Value.Length)
            {
                int endIndex = Value.IndexOf(Environment.NewLine, StartIndex);
                bool isFinal = endIndex == -1;

                if (isFinal)
                {
                    Line = Value[StartIndex..];
                    StartIndex = Value.Length;
                }
                else
                {
                    Line = Value[StartIndex..endIndex];
                    StartIndex = endIndex + Environment.NewLine.Length;
                }

                result = true;
            }

            return await Task.FromResult(result);
        }

        public void Dispose() { }
    }
}
