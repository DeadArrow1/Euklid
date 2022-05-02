using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class EuklidAlgorithmTests
    {
        [TestMethod()]
        public void GCDTest1()
        {
            int a = 3;
            int b = 5;

            int result = EuklidAlgorithm.GCD(a, b);

            if (result != 1)
            {
                Assert.Fail("Result expected: 1 but was: " + result);
            }
        }

        [TestMethod()]
        public void GCDTest2()
        {
            int a = 5;
            int b = 3;

            int result = EuklidAlgorithm.GCD(a, b);

            if (result != 1)
            {
                Assert.Fail("Result expected: 1 but was: " + result);
            }
        }

        [TestMethod()]
        public void GCDTest3()
        {
            int a = 40902;
            int b = 24140;

            int result = EuklidAlgorithm.GCD(a, b);

            if (result != 34)
            {
                Assert.Fail("Result expected: 34 but was: " + result);
            }
        }

        [TestMethod()]
        public void GCDTest4()
        {
            int a = 270;
            int b = 192;

            int result = EuklidAlgorithm.GCD(a, b);

            if (result != 6)
            {
                Assert.Fail("Result expected: 6 but was: " + result);
            }
        }


        [TestMethod()]
        public void GCDTest5()
        {
            int a = 300;
            int b = 816;

            int result = EuklidAlgorithm.GCD(a, b);

            if (result != 12)
            {
                Assert.Fail("Result expected: 12 but was: " + result);
            }
        }

        [TestMethod()]
        public void MultiplicativeInversionTest1()
        {
            int a = 61;
            int b = 97;

            int result = EuklidAlgorithm.MultiplicativeInversion(a, b);

            if (result != 35)
            {
                Assert.Fail("Result expected: 35 but was: " + result);
            }
        }

        [TestMethod()]
        public void MultiplicativeInversionTest2()
        {
            int a = 10;
            int b = 2;

            int result = EuklidAlgorithm.MultiplicativeInversion(a, b);
            if (result != 0)
            {
                Assert.Fail("Result expected: 0 but was: " + result);
            }
        }

        [TestMethod()]
        public void MultiplicativeInversionTest3()
        {
            int a = -10;
            int b = 2;


            int result = EuklidAlgorithm.MultiplicativeInversion(a, b);
            if (result != 0)
            {
                Assert.Fail("Result expected: 0 but was: " + result);
            }
        }

        [TestMethod()]
        public void MultiplicativeInversionTest4()
        {
            int a = 13;
            int b = 51;


            int result = EuklidAlgorithm.MultiplicativeInversion(a, b);
            if (result != 4)
            {
                Assert.Fail("Result expected: 4 but was: " + result);
            }
        }


    }
}