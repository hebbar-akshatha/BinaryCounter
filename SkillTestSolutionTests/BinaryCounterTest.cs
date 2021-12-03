using NUnit.Framework;
using SkillTestSolutionLibrary;
using System;

namespace SkillTestSolutionTests
{
    public class BinaryCounterTest
    {
        private BinaryCounter binCounterTest;

        [SetUp]
        public void Setup()
        {
            binCounterTest = new BinaryCounter();
        }

        [Test]
        public void TestFor10()
        {
            string outputText = "1010 1001 1000 111 110 101 100 11 10 01 00 " + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                binCounterTest.BinCount("10");
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestFor50()
        {
            string outputText = "110010 110001 110000 101111 101110 101101 101100 101011 101010 101001 101000 100111 100110 100101 100100 100011 100010 100001 100000 11111 11110 11101 11100 11011 11010 11001 11000 10111 10110 10101 10100 10011 10010 10001 10000 1111 1110 1101 1100 1011 1010 1001 1000 111 110 101 100 11 10 01 00 " + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                binCounterTest.BinCount("50");
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestForLessThanZero()
        {
            Assert.Throws<Exception>(() => binCounterTest.BinCount("-20"));
        }

        [Test]
        public void TestForMoreThanHundred()
        {
            Assert.Throws<Exception>(() => binCounterTest.BinCount("200"));
        }

        [Test]
        public void TestForInvalidCharacters()
        {
            Assert.Throws<FormatException>(() => binCounterTest.BinCount("abcde"));
        }

        [Test]
        public void TestForOverflowException()
        {
            Assert.Throws<OverflowException>(() => binCounterTest.BinCount("123872103720313123"));
        }
    }
}