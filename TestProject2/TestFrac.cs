

namespace TestProject2
{
    [TestClass]
    public class TestFrac
    {
        [TestMethod]
        public void TestAdd()
        {
            MyFrac frac1 = new(1, 2);
            MyFrac frac2 = new(2, 3);
            string expected = "7/6";
            string actual = frac1.Add(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAdd2()
        {
            MyFrac frac1 = new(-3, 4);
            MyFrac frac2 = new(1, 2);
            string expected = "-1/4";
            string actual = frac1.Add(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul1()
        {
            MyFrac frac1 = new(-3, 4);
            MyFrac frac2 = new(1, 2);
            string expected = "-3/8";
            string actual = frac1.Multiply(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul2()
        {
            MyFrac frac1 = new(-3, 4);
            MyFrac frac2 = new(1, -2);
            string expected = "3/8";
            string actual = frac1.Multiply(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv1()
        {
            MyFrac frac1 = new(-3, 4);
            MyFrac frac2 = new(1, 2);
            string expected = "-3/2";
            string actual = frac1.Divide(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv2()
        {
            MyFrac frac1 = new(-3, 4);
            MyFrac frac2 = new(1, -2);
            string expected = "3/2";
            string actual = frac1.Divide(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCopyCon()
        {
            MyFrac frac1 = new(-3, 4);
            MyFrac frac2 = frac1;
            string expected = frac1.ToString();
            string actual = frac2.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}