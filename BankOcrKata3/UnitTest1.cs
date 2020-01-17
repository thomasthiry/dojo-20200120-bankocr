using System;
using Shouldly;
using Xunit;

namespace BankOcrKata3
{
    //    _  _     _  _  _  _  _ 
    //  | _| _||_||_ |_   ||_||_|
    //  ||_  _|  | _||_|  ||_| _|

    public class UnitTest1
    {
        [Fact]
        public void ParseOne()
        {
            var input = new[]
            {
                "  ", 
                "  |", 
                "  |"
            };
            var result = new Parser().Parse(input);

            result.ShouldBe(1);
        }
    }

    public class Parser
    {
        public int Parse(string[] input)
        {
            throw new NotImplementedException();
        }
    }
}
