using System;
using System.Collections.Generic;
using System.Text;

namespace SkillTestSolutionLibrary
{
    public class BinaryCounter : IInput
    {
        public string InputMessage => "Please enter a number between 0 and 100";

        private Stack<string> outputStack = new Stack<string>();

        /// <summary>
        /// This is the entrypoint for BinCount. 
        /// For formatting purposes, 0 and 1 have been pushed into stack as 00 and 01.
        /// All other numbers follow the ComputeBinaryString logic.
        /// </summary>
        /// <param name="binCountStr"></param>
        public void BinCount(string binCountStr)
        {
            //read number from user   
            int input = Convert.ToInt32(binCountStr);

            if (input < 0 || input > 100)
                throw new Exception("You have entered a number that is either less than 0 or more than 100. Please enter a number between 0 and 100.");

            int i = 0;
            while (i <= input)
            {
                if (i == 0)
                    outputStack.Push("00");

                if (i == 1)
                    outputStack.Push("01");

                if(i > 1)
                    this.ComputeBinaryString(i);
                i++;
            }

            this.Print();
            Console.WriteLine(Environment.NewLine);
        }

        private void Print()
        {
            while (outputStack.Count != 0)
            {
                Console.Write(outputStack.Pop());
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Since binary is 0 or 1 which is true or false, based on the remainder of the number, a true or false is 
        /// pushed onto the stack and then assimilated back as necessary. 
        /// </summary>
        /// <param name="numberToConvert"></param>
        private void ComputeBinaryString(int numberToConvert)
        {
            string binString = string.Empty;
            Stack<bool> binaryStack = new Stack<bool>();
            while (numberToConvert > 0)
            {
                int rem = numberToConvert % 2;
                binaryStack.Push(rem!=0);
                numberToConvert = numberToConvert / 2;
            }
            
            while(binaryStack.Count != 0)
            {
                binString += binaryStack.Pop() ? "1" : "0";
            }

            outputStack.Push(binString);
        }
    }
}
