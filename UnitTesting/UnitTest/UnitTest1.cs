using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var TestResult = program.Add(5, 10);
            Assert.AreEqual(15,TestResult);
        }
    }
}