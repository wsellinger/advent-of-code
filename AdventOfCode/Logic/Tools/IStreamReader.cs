namespace AdventOfCode.Logic.Tools
{
    public interface IStreamReader : IDisposable
    {
        public Task<string?> ReadLineAsync();
    }
}
