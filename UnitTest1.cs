using NUnit.Framework;
[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(3, 5, 8)]
    [TestCase(-5, 10, 5)]
    [TestCase(9, 0, 9)]
    [TestCase(-5, -5, -10)]
    public void addTest(int a, int b, int result)
    {
        Calculator cal = new Calculator();
        int addResult = cal.Add(a, b);
        Assert.That(addResult, Is.EqualTo(result));
    }

    [TestCase(5, 3, 2)]
    [TestCase(-5, 10, -15)]
    [TestCase(1, 7, -6)]
    [TestCase(-5, -8, 3)]
    public void subTest(int a, int b, int result)
    {
        Calculator cal = new Calculator();
        int subResult = cal.Sub(a, b);
        Assert.That(subResult, Is.EqualTo(result));
    }


    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 24)]
    [TestCase(5, 120)]
    public void factorialTest(int n, long result)
    {
        Calculator cal = new Calculator();
        long factorialResult = cal.factorial(n);
        Assert.That(factorialResult, Is.EqualTo(result));
    }

    [OneTimeTearDown]
    public void Close()
    {
    }
}
