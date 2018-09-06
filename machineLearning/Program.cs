using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using machineLearning.Interfaces;

namespace machineLearning
{
    class Program
    {

        static void Main(string[] args)
        {
            IClassifier classifier = new BasicClassifier();

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
            var recordsArray = records.ToArray();
            Console.WriteLine("Training done");
            
            
            string[] dataToValidate = File.ReadAllLines("validationsample.csv");
            var rawDataToValidate = dataToValidate.Skip(1);
            var rawDataSplittedToValidate = rawDataToValidate.Select(x => x.Split(',')).ToArray();
            var recordsToValidate = rawDataSplittedToValidate.Select(x =>
            new Record
            {
                Number = int.Parse(x.First()),
                Pixels = (x.Skip(1).Select(n => int.Parse(n)).ToArray())
            }
            );
            Console.WriteLine("Validate done");
            var recordToValidate = recordsToValidate.Last();

            var results =  classifier.Predict(recordToValidate, recordsArray).ToArray();
            var sortedResult = results.OrderBy(x => x.Distance).First(); 
            Console.WriteLine($"Number:{sortedResult.Number}, distance: {sortedResult.Distance}");
            Console.ReadLine();

        }
      
    }
}
