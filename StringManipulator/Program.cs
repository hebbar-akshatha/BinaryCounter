using SkillTestSolutionLibrary;
using System;
using System.Text.RegularExpressions;

namespace FormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulator strMan = new StringManipulator();

            while (true)
            {
                Console.WriteLine(strMan.InputMessage);
                string input = Console.ReadLine();
                input = input.Trim();

                if (input == "X" || input == "x")
                    return;

                try
                {
                    strMan.ConvertAndPrint(input);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        
    }
}
