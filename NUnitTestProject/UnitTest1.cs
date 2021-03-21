using NUnit.Framework;
using TestProject;

namespace NUnitTestProject
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FoundMax2ndTest1()
        {
            int[] testArr = { 1, 15, 4, 5, 3, 9, 15, 300 };
            int result = Arrays.FoundMax2nd(testArr);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void FoundMax2ndTest2()
        {
            int[] testArr = {1};
            int result = Arrays.FoundMax2nd(testArr);
            Assert.AreEqual(1, result);
           
        }
        [Test]
        public void FoundMax2ndTest3()
        {
            int[] testArr = {};
            int result = Arrays.FoundMax2nd(testArr);
            Assert.AreEqual(1, result);

        }
    }
}