

namespace TestProject2
{
    [TestClass]
    public class TestComplex
    {
        [TestMethod]
        public void TestAdd1()
        {
            MyComplex comp1 = new(3, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Add(comp2);
            MyComplex expected = new(8, -3);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }

        [TestMethod]
        public void TestAdd2()
        {
            MyComplex comp1 = new(-3, 2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Add(comp2);
            MyComplex expected = new(2, 1);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestMinus()
        {
            MyComplex comp1 = new(3, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Subtract(comp2);
            MyComplex expected = new(-2, -1);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestMul()
        {
            MyComplex comp1 = new(3, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Multiply(comp2);
            MyComplex expected = new(13, -13);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }

        [TestMethod]
        public void TestDiv()
        {
            MyComplex comp1 = new(3, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Divide(comp2);
            MyComplex expected = new(17 / 26.0, -7/26.0);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }

        [TestMethod]
        public void TestCopyCon()
        {
            MyComplex comp1 = new(3, -2);
            MyComplex comp2 = new(comp1);
            string act = comp1.ToString();
            string exp = comp2.ToString();
            Assert.AreEqual(act, exp);
        }
    }
}