using AssignmentQ1;
namespace Test
{
    [TestClass]
    public sealed class Test
    {
        [TestMethod]
        public void Add()
        {
            Calculator cal = new Calculator();
            double res = cal.Add(20, 3);
            Assert.AreEqual(res, 23);
        }
        [TestMethod]
        public void Sub()
        {
            Calculator cal = new Calculator();
            double res = cal.Subtract(20, 30);
            Assert.AreEqual(res, -10);
        }
        [TestMethod]
        public void Mul()
        {
            Calculator cal = new Calculator();
            double res = cal.Multiply(10, 4);
            Assert.AreEqual(res, 40);
        }
        [TestMethod]
        public void Div()
        {

            Calculator cal = new Calculator();
            double res = cal.Divide(30, 3);
            Assert.AreEqual(10, res);

        }
        [TestMethod]
        public void DivbyZero()
        {
            Calculator cal = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => cal.Divide(10, 0));
        }

    }

}
