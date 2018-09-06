using Microsoft.VisualStudio.TestTools.UnitTesting;
using machineLearning.Interfaces;
using machineLearning;
using System.Diagnostics;

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
            int[] a = {1, 1, 4 };
            record.Pixels = a;

            Record record1 = new Record();
            record.Number = 1;
            int[] b = {1, 3, 4 };
            record1.Pixels = b;

            Result expectedResult = new Result();
            expectedResult.Distance = 2;
            expectedResult.Number = 1;


            Distance distance = new Distance();
            //act
            var result = distance.Between(record,record1);
            //assert
            Debug.WriteLine(result);
            System.Console.WriteLine(result);
            Assert.AreEqual(expectedResult.Distance, result.Distance);
        }
    }
}
