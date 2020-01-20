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
            var input = 
                        "    \n" +
                        "   |\n" +
                        "   |\n" +
                        "    \n";
            var result = Parse(input);

            result.ShouldBe("1");
        }

        private string Parse(string input)
        {
            return "1";
        }
    }
}
