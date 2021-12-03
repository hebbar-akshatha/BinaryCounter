using NUnit.Framework;
using SkillTestSolutionLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTestSolutionTests
{
    public class StringManipulatorTest
    {
        private StringManipulator stringManiTest;

        [SetUp]
        public void Setup()
        {
            stringManiTest = new StringManipulator();
        }

        [Test]
        public void TestForValidCase1()
        {
            string outputText = "aLPHaBeT13" + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                stringManiTest.ConvertAndPrint("alphabet01234");
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestForValidCase2()
        {
            string outputText = "JaG3KHui7" + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                stringManiTest.ConvertAndPrint("0jag34khui876!*&");
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestForValidCase3()
        {
            string outputText = "aDoaiuoiuQTWeuQWTReNBMCV13513977DaSD" + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                stringManiTest.ConvertAndPrint("adoaiuoiuqtweuqwtrenbmcv12835183290787^%$#@*&dasd");
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
