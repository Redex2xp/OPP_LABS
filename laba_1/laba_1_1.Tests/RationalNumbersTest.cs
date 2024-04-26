using laba_1_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace laba_1_1.Tests;

[TestClass]
public class RationalNumbersTest
{

    [TestMethod]
    public void Sum()
    {
        RationalNumbers num1 = new RationalNumbers(1, 2);
        RationalNumbers num2 = new RationalNumbers(2, 9);
        RationalNumbers num3 = new RationalNumbers(13, 18);
        Assert.IsTrue(num1 + num2 == num3);
    }

    [TestMethod]
    public void Div()
    {
        RationalNumbers num1 = new RationalNumbers(1, 2);
        RationalNumbers num2 = new RationalNumbers(2, 9);
        RationalNumbers num3 = new RationalNumbers(5, 18);
        Assert.IsTrue(num1-num2 == num3);
    }
    
    [TestMethod]
    public void Equal()
    {
        RationalNumbers num1 = new RationalNumbers(1, 2);
        RationalNumbers num2 = new RationalNumbers(1, 2);
        Assert.IsTrue(num1 == num2);
    }
    
    [TestMethod]
    public void NotEqual()
    {
        RationalNumbers num1 = new RationalNumbers(1, 2);
        RationalNumbers num2 = new RationalNumbers(1, 3);
        Assert.IsTrue(num1 != num2);
    }
}
