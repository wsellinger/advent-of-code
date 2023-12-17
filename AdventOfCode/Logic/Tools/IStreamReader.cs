namespace AdventOfCode.Logic.Tools
{
    public interface IStreamReader : IDisposable
    {
        public Task<string?> ReadLineAsync();
        public Task<bool> TryReadLineAsync();
        public string Line {  get; }
    }
}
