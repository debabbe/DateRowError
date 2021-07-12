using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataRowError
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(true)]
        [DataRow(false)]
        [DataTestMethod]
        public void Test(bool boolean)
        {
            Assert.AreEqual(boolean, boolean);
        }
    }
}
