using System;

namespace stringCalculatorTDD
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            
            int result; //default of int is 0

            if (input == string.Empty)
            {
                return 0;
            }
            if (int.TryParse(input, out result)) //single input 
            {
                return result;
            }

            char anyDelimiter;
            string[] resultStrings;
            if (input.Contains("//"))
            {
                anyDelimiter = input[2];
                resultStrings = input.Split(anyDelimiter, ',', '\n');
               
                foreach (string resultString in resultStrings)
                {
                    Int32.TryParse(resultString, out int resultNum);
                    result += resultNum;
                }
            }
            else
            {
                char[] delimiter = {',', '\n' };
                string[] splitInput = input.Split(delimiter);
                foreach (string stringNum in splitInput)
                {
                    result += int.Parse(stringNum);
                }
            }

            return result;
        }
    }
}