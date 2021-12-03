using System;
using System.Text;
using SkillTestSolutionLibrary;

namespace BinaryCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            SkillTestSolutionLibrary.BinaryCounter binCounter = new SkillTestSolutionLibrary.BinaryCounter();
            while (true)
            {
                Console.WriteLine(binCounter.InputMessage);
                string input = Console.ReadLine();
                input = input.Trim();

                if (input == "X" || input == "x")
                    return;

                try
                {
                    binCounter.BinCount(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The given number is not an integer");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The given number exceeds the max value of type integer");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }       
        
    }
}
