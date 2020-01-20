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

        [Fact]
        public void ParseTwo()
        {
            var input = 
                " _ \n" +
                " _|\n" +
                "|_ \n" +
                "   \n";
            var result = Parse(input);

            result.ShouldBe("2");
        }

        private string Parse(string input)
        {
            var firstLine = input.Split('\n')[0];

            if (isEmptyLine(firstLine))
            {
                return "1";
            }

            return "2";
        }

        private static bool isEmptyLine(string line)
        {
            return line == "    ";
        }
    }
}
