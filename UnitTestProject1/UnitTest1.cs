using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int size = 0;
            Assert.IsTrue(size <= 0, "Test Method 1 has passed");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int size = 1;
            for (size = 1; size < 10; size++)
                Assert.IsTrue((size > 0) && (size < 10), "Test Method 2 has passed");
        }

        [TestMethod]
        public void TestMethod3()
        {
            char size = '\0';
            do
            {
                if (((int)size < 48) && ((int)size > 58))
                {
                    Assert.IsTrue(((int)size < 48) && ((int)size > 58), "Test Method 3 has passed");
                }
                size++;
            } while ((int)size < 256);

        }
        [TestMethod]
        public void TestMethod4()
        {
            int size = 1, digi_1;
            for (size = 1; size < 10; size++)
            {
                for (digi_1 = 1; digi_1 <= size; digi_1++)
                {
                    Assert.IsTrue((digi_1 <= size), "Test Method 4 has passed");
                }

            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            int size = 1, digi_2;
            for (size = 1; size < 10; size++)
            {
                for (digi_2 = 1; digi_2 <= size; digi_2++)
                {
                    Assert.IsTrue((digi_2 <= size), "Test Method 5 has passed");
                }

            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            int size = -1;
            Assert.IsTrue(size <=0, "Test Method 6 has passed");
        }

        [TestMethod]
        public void TestMethod7()
        {
            int digi_1 = -1;
            Assert.IsFalse(digi_1<0, "Test Method 7 has failed");
        }

        [TestMethod]
        public void TestMethod8()
        {
            int digi_2 = -1;
            Assert.IsFalse(digi_2 < 0, "Test Method 8 has failed");
        }

    }
}
