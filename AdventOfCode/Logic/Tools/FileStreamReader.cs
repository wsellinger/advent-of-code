namespace AdventOfCode.Logic.Tools
{
    public class FileStreamReader(string path) : IStreamReader
    {
        public string Line { get; private set; } = string.Empty;

        private StreamReader Reader { get; init; } = new(path);

        public async Task<bool> ReadLineAsync()
        {
            string? line = await Reader.ReadLineAsync();
            Line = line ?? string.Empty;

            return line != null;
        }

        public void Dispose() => Reader.Dispose();
    }
}
