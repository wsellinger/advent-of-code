using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Logic.Exceptions
{
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base("File Empty") { }
    }
}
