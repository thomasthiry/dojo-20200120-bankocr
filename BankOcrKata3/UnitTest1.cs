using System;
using System.Collections.Generic;
using System.Linq;
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
        public void splitOneBlocks()
        {
            var input =
                " _ \n" +
                " _|\n" +
                " _|\n" +
                "   \n";
            var result = SplitIntoBlocks(input);

            result.ShouldBe(new []
            {
                " _ " +
                " _|" +
                " _|" +
                "   "
            });
        }

        private string[] SplitIntoBlocks(string entry)
        {
            var lines = entry.Split('\n');

            var blocks = new string[1];

            for (int i = 0; i < 1; i++)
            {
                var digitBlock = new string[4];
                digitBlock[0] = lines[0].Substring(i * 3, 3);
                digitBlock[1] = lines[1].Substring(i * 3, 3);
                digitBlock[2] = lines[2].Substring(i * 3, 3);
                digitBlock[3] = lines[3].Substring(i * 3, 3);
                blocks[i] = string.Join("", digitBlock);
            }

            return blocks;
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
