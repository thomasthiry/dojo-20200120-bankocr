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
        private const int BlockWidth = 3;

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
                " _ \n" +
                " _|\n" +
                " _|\n" +
                "   \n"
            });
        }

        [Fact]
        public void splitTwoBlocks()
        {
            var input =
                " _    \n" +
                " _|  |\n" +
                " _|  |\n" +
                "      \n";
            var result = SplitIntoBlocks(input);

            result.ShouldBe(new []
            {
                " _ \n" +
                " _|\n" +
                " _|\n" +
                "   \n",
                "   \n" +
                "  |\n" +
                "  |\n" +
                "   \n"
            });
        }

        private string[] SplitIntoBlocks(string entry)
        {
            var lines = entry.Split('\n');

            var numberOfDigits = lines[0].Length / BlockWidth;
            var blocks = new string[numberOfDigits];

            for (int blockIndex = 0; blockIndex < numberOfDigits; blockIndex++)
            {
                blocks[blockIndex] = ExtractBlock(lines, blockIndex);
            }

            return blocks;
        }

        private static string ExtractBlock(string[] lines, int blockIndex)
        {
            var digitBlock = new string[4];
            digitBlock[0] = lines[0].Substring(blockIndex * BlockWidth, BlockWidth);
            digitBlock[1] = lines[1].Substring(blockIndex * BlockWidth, BlockWidth);
            digitBlock[2] = lines[2].Substring(blockIndex * BlockWidth, BlockWidth);
            digitBlock[3] = lines[3].Substring(blockIndex * BlockWidth, BlockWidth);
            return string.Join("\n", digitBlock) + "\n";
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
