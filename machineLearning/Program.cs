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
            var rawDataSplitted = rawData.Select(x => x.Split(',')).ToArray();
            var records = rawDataSplitted.Select(x =>
            new Record
            {
                Number = int.Parse(x.First()),
                Pixels = (x.Skip(1).Select(n => int.Parse(n)).ToArray())
            }
            );
            Console.ReadLine();

            string[] dataToValidate = File.ReadAllLines("validationsample.csv");
            var rawDataToValidate = data.Skip(1);
            var rawDataSplittedToValidate = rawDataToValidate.Select(x => x.Split(',')).ToArray();
            var recordsToValidate = rawDataSplittedToValidate.Select(x =>
            new Record
            {
                Number = int.Parse(x.First()),
                Pixels = (x.Skip(1).Select(n => int.Parse(n)).ToArray())
            }
            );
            Console.ReadLine();

        }
      
    }
}
