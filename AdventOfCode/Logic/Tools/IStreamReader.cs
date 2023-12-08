namespace AdventOfCode.Logic.Tools
{
    public interface IStreamReader : IDisposable
    {
        public Task<bool> ReadLineAsync();
        public string Line {  get; }
    }
}
