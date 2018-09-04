using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace machineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("trainingsample.csv");
            var rawData = data.Skip(1);
            var rawDataSplitted = rawData.Select(x => x.Split(','));
            var rawDataInt = rawDataSplitted.Select(x => x.Select(n => int.Parse(n)));
            List<int> pixelList = new List<int>();
            var records = rawDataInt.Select(x =>
            new Record
            {
                Number = x.First(),
                Pixels = x.Skip(1).ToArray()
            }
            );

            
        }
      
    }
}
