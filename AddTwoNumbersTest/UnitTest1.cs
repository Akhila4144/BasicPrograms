using AddTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddTwoNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sum sum = new Sum();
            int a = 5;
            int b = 10;
            int expected = 15;
            int actual=sum.getSum(a,b);
            Assert.AreEqual(expected, actual);
        }
    }
}
