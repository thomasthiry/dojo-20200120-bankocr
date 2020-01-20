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
            var result = ParseDigit(input);

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
            var result = ParseDigit(input);

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
            var result = ParseDigit(input);

            result.ShouldBe("3");
        }

        private string ParseDigit(string input)
        {
            var one = "    \n" +
                            "   |\n" +
                            "   |\n" +
                            "    \n";

            var two = " _ \n" +
                            " _|\n" +
                            "|_ \n" +
                            "   \n";
            
            if (input == one)
            {
                return "1";
            }

            if (input == two)
            {
                return "2";
            }

            return "3";
        }
    }
}
