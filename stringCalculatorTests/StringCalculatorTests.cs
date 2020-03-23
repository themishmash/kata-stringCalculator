using NUnit.Framework;
using stringCalculatorTDD;

namespace stringCalculatorTests
{
    public class StringCalculatorTests
    {
        

        [Test]
        public void AddEmptyStringReturnsZero()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("");
            
            Assert.AreEqual(0,result);
        }
        
        [Test]
        public void AddNumberReturnsNumber()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1");
            
            Assert.AreEqual(1,result);
        }
        
        
    }
}