using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SkillTestSolutionLibrary
{
    public class StringManipulator : IInput
    {
        public string InputMessage => "Please enter an alphanumeric string.";

        /// <summary>
        /// This is the entrypoint for StringManipulator.
        /// The regular expression excludes even numbers and any special characters from the input string.
        /// The other characters follow the ConvertCase logic. 
        /// </summary>
        /// <param name="inputStr"></param>
        public void ConvertAndPrint(string inputStr)
        {
            string output = string.Empty;
            string regexStr = Regex.Replace(inputStr, @"[^13579a-zA-Z]+", "");
            for (int i = 0; i < regexStr.Length; i++)
            {
                // Check for vowel
                output += ConvertCase(regexStr[i]);
            }
            Console.WriteLine(output);
        }

        /// <summary>
        /// Convert vowels to lower case and consonants to upper case.
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        private char ConvertCase(char ch)
        {
            char ochar;
            ch = char.ToLower(ch);
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    ochar = ch;
                    break;
                default:
                    ochar = char.ToUpper(ch);
                    break;
            }

            return ochar;
        }
    }
}
