namespace AdventOfCode.Logic.Exceptions
{
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base("File Empty") { }
    }
}
