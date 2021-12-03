using NUnit.Framework;
using SkillTestSolutionLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTestSolutionTests
{
    public class CanvasTest
    {
        [Test]
        public void TestForValidCase1()
        {
            Canvas canvasTest = new Canvas();

            string outputText = "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a box at..." +Environment.NewLine;
            outputText += "Drawing a circle at..." +Environment.NewLine;
            outputText += "Drawing a line at..." +Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                canvasTest.InitializeShape("clbclb");
                canvasTest.Draw();
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestForValidCase2()
        {
            Canvas canvasTest = new Canvas();

            string outputText = "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                canvasTest.InitializeShape("bbblllccc");
                canvasTest.Draw();
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestForValidCase3()
        {
            Canvas canvasTest = new Canvas();

            string outputText = "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a line at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a circle at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            outputText += "Drawing a box at..." + Environment.NewLine;
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                canvasTest.InitializeShape("blccbllllbcccbbb");
                canvasTest.Draw();
                Assert.AreEqual(outputText, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [Test]
        public void TestForException1()
        {
            Canvas canvasTest = new Canvas();

            Assert.Throws<Exception>(() => canvasTest.InitializeShape("aywueyqcaa"));
                
        }

        [Test]
        public void TestForException2()
        {
            Canvas canvasTest = new Canvas();

            Assert.Throws<Exception>(() => canvasTest.InitializeShape("opulbasdqeuy"));

        }
    }
}

