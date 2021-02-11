using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainModule.Test
{
    [TestClass]
    public class ArrayManagerTests
    {
        [TestMethod]
        public void FindMax_PositiveElements_Test()
        {
            int[] arr = { 3, 8, 1, 21, 5 };
            int expected = 21;

            int actual = ArrayManager.FindMax(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}