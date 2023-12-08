namespace AdventOfCode.Logic.Tools
{
    public class StringStreamReader(string value) : IStreamReader
    {
        private string Value { get; init; } = value;
        private int StartIndex { get; set; } = 0;

        public async Task<string?> ReadLineAsync()
        {
            string? result = null;

            if (StartIndex != Value.Length)
            {
                int endIndex = Value.IndexOf(Environment.NewLine, StartIndex);
                if (endIndex != -1)
                {
                    result = Value[StartIndex..endIndex];
                    StartIndex = endIndex + Environment.NewLine.Length;
                }
                else
                {
                    result = Value[StartIndex..];
                    StartIndex = Value.Length;
                }
            }

            return await Task.FromResult(result);
        }

        public void Dispose() { }
    }
}
