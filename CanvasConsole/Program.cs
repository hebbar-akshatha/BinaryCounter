using SkillTestSolutionLibrary;
using System;

namespace CanvasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();

            while (true)
            {
                Console.WriteLine(canvas.InputMessage);
                string input = Console.ReadLine();
                input = input.Trim();

                if (input == "X" || input == "x")
                    return;

                try
                {
                    canvas.InitializeShape(input);
                    canvas.Draw();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            } 


        }
    }
}
