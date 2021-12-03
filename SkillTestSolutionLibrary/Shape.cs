using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTestSolutionLibrary
{
    internal abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape at...");
        }
    }
}
