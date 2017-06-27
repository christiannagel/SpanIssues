using System;

namespace SpanTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, World!";
            ReadOnlySpan<char> span = s.AsSpan();
            string s2 = span.ToString();  // exception: Unhandled Exception: System.InvalidProgramException: Common Language Runtime detected an invalid program.
        }
    }
}
