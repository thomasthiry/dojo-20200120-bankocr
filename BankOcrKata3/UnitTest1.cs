using System;
using System.Collections.Generic;
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
            var result = ParseDigitBlock(input);

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
            var result = ParseDigitBlock(input);

            result.ShouldBe("2");
        }

        [Fact]
        public void ParseThree()
        {
            var input =
                " _ \n" +
                " _|\n" +
                " _|\n" +
                "   \n";
            var result = ParseDigitBlock(input);

            result.ShouldBe("3");
        }

        [Fact]
        public void parseTwoBlocks()
        {
            var input =
                " _     \n" +
                " _|   |\n" +
                " _|   |\n" +
                "       \n";
            var result = ParseSomething(input);
            result.ShouldBe("31");
        }

        [Fact]
        public void splitTwoBlocks()
        {
            var input =
                " _     \n" +
                " _|   |\n" +
                " _|   |\n" +
                "       \n";
            var result = SplitSomething(input);

            result.ShouldBe(new []
            {
                " _ " +
                " _|" +
                " _|" +
                "   ",
                "   " +
                "  |" +
                "  |" +
                "   "
            });
        }

        private string[] SplitSomething(string input)
        {
            return new[] { ""};
        }

        private string ParseSomething(string something)
        {
            return "31";
        }

        private string ParseDigitBlock(string block)
        {
            var one = 
                      "    \n" +
                      "   |\n" +
                      "   |\n" +
                      "    \n";

            var two =
                      " _ \n" +
                      " _|\n" +
                      "|_ \n" +
                      "   \n";

            var three =
                " _ \n" +
                " _|\n" +
                " _|\n" +
                "   \n";

            var blockToDigit = new Dictionary<string, string> {{one, "1"}, {two, "2"}, {three, "3"}};

            return blockToDigit[block];
        }
    }
}
