using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using machineLearning.Interfaces;
using machineLearning.InputHelpers;

namespace machineLearning
{
    class Program
    {

        static void Main(string[] args)
        {
            IClassifier classifier = new BasicClassifier();

            ReadHelper trainingSamples = new ReadHelper("trainingsample.csv");
            var trainingSample = trainingSamples.Records;
            Console.WriteLine("Training done");

            Console.WriteLine("Which image(as row of file) would you like to identify?");
            var k = int.Parse(Console.ReadLine());

            ReadHelper validationSamples = new ReadHelper("validationsample.csv");
            var recordToValidate = validationSamples.Records[k];
            Console.WriteLine("Validate done");

            var result =  classifier.Predict(recordToValidate, trainingSamples.Records).ToArray();
            var sortedResult = result.OrderBy(x => x.Distance).First(); 
            Console.WriteLine($"Probably it is {sortedResult.Number}, it's distance is {Math.Floor(sortedResult.Distance)}");
            Console.ReadLine();

           // var results = validationSamples.Records.Select(x => classifier.Predict(x, trainingSamples.Records)).ToArray();

        }
      
    }
}
