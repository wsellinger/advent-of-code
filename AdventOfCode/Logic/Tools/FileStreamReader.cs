namespace AdventOfCode.Logic.Tools
{
    public class FileStreamReader(string path) : IStreamReader
    {
        private StreamReader Reader { get; init; } = new(path);

        public async Task<string?> ReadLineAsync()
        {
            return await Reader.ReadLineAsync();
        }

        public void Dispose() => Reader.Dispose();
    }
}
