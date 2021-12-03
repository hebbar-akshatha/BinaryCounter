using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SkillTestSolutionLibrary
{
    public class Canvas : IInput
    {
        private List<Shape> shapes = new List<Shape>();

        public string InputMessage => "Please enter shapes. Valid values are c, l or b. The program is not case sensitive. Press X to exit at any time.";

        /// <summary>
        /// This is the entry point for Draw method.
        /// </summary>
        public void Draw()
        {
            this.shapes.ForEach(sh => sh.Draw());
        }

        /// <summary>
        /// This is the modification to read shape input for Question 4.
        /// </summary>
        /// <param name="inputShape"></param>
        public void InitializeShape(string inputShape)
        {
            if (String.IsNullOrEmpty(inputShape) || string.IsNullOrWhiteSpace(inputShape))
                return;

            if (Regex.IsMatch(inputShape, @"[^clbCLB]+"))
                throw new Exception("There's an invalid character in the Shape input. Valid shapes are c(circle), l(line) or b(box)");

            foreach(char sh in inputShape)
            {
                this.CreateShape(Char.ToUpper(sh));
            }
        }

        private void CreateShape(char shapeChar)
        {
            Shape newShape = null;
            switch (shapeChar)
            {
                case 'C':
                    newShape = new Circle();
                    break;
                case 'L':
                    newShape = new Line();
                    break;
                case 'B':
                    newShape = new Box();
                    break;
            }

            this.shapes.Add(newShape);
        }
    }
}
