namespace stringCalculatorTDD
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            int result;
            int.TryParse(input, out result);
            return result;
        }
    }
}