namespace AdventOfCode.Logic.Tools
{
    public class FileStreamReader(string path) : IStreamReader
    {
        public string Line { get; private set; } = string.Empty;

        private StreamReader Reader { get; init; } = new(path);

        public async Task<bool> TryReadLineAsync()
        {
            string? line = await Reader.ReadLineAsync();
            Line = line ?? string.Empty;

            return line != null;
        }

        public async Task<string?> ReadLineAsync()
        {
            bool isReturned = await TryReadLineAsync();
            return isReturned ? Line : null;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Reader.Dispose();
        }
    }
}
