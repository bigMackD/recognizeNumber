using Microsoft.VisualStudio.TestTools.UnitTesting;
using machineLearning.Interfaces;

namespace Methods.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Between_getsTwoPoints_returns2dDistance()
        {
            //arrange
            int[] a = { 1, 4 };
            int[] b = { 3, 4 };
          
            Distance distance = new Distance();
            //act
            var result = distance.Between(a, b);
            //assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Between_getsThreePoints_returns2dDistance()
        {
            //arrange
            int[] a = { 7, 4, 3 };
            int[] b = { 7, 4, 2 };

            Distance distance = new Distance();
            //act
            var result = distance.Between(a, b);
            //assert
            Assert.AreEqual(1, result);
        }
    }
}
