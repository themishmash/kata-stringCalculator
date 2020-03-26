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
            
            Assert.AreEqual(1,stringCalculator.Add("1"));
            Assert.AreEqual(3,stringCalculator.Add("3"));
        }

        [Test]
        public void AddTwoNumbersReturnsSum()
        {
            var stringCalculator = new StringCalculator();

            Assert.AreEqual(3, stringCalculator.Add("1,2"));
            Assert.AreEqual(8, stringCalculator.Add("3,5"));
        }

        [Test]
        public void AddAnyNumbersReturnsSum()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(6, stringCalculator.Add("1,2,3"));
            Assert.AreEqual(20, stringCalculator.Add("3,5,3,9"));
        }

        [Test]
        public void AddAnyNumbersReturnsSumWithLineBreaks()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(6, stringCalculator.Add("1,2\n3"));
            Assert.AreEqual(20, stringCalculator.Add("3\n5\n3,9"));
        }

        [Test]
        public void AddDifferentDelimitersReturnsSum()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(3, stringCalculator.Add("//;\n1;2"));
        }
    }
}