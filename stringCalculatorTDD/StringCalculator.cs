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

         
            char[] delimiter = {',', '\n' };
            string[] splitInput = input.Split(delimiter);
            foreach (string letter in splitInput)
            {
                result += int.Parse(letter);
            }

            return result;
        }
    }
}