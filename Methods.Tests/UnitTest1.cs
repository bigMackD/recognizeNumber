using Microsoft.VisualStudio.TestTools.UnitTesting;
using machineLearning.Interfaces;
using machineLearning;

namespace Methods.Tests
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void Between_getsThreePoints_returns2dDistance()
        {
            //arrange
            Record record = new Record();
            record.Number = 1;
            int[] a = { 1, 4 };
            record.Pixels = a;

            Record record1 = new Record();
            record.Number = 1;
            int[] b = { 3, 4 };
            record.Pixels = b;

            Distance distance = new Distance();
            //act
            var result = distance.Between(record,record1);
            //assert
            Assert.AreEqual(0, result);
        }
    }
}
