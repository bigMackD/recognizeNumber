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

            //Console.WriteLine("Which image(as row of file) would you like to identify?");
            //var k = int.Parse(Console.ReadLine());

            ReadHelper validationSamples = new ReadHelper("validationsample.csv");
            var recordsToValidate = validationSamples.Records;
            //var recordToValidate = validationSamples.Records[k];
            Console.WriteLine("Validate done");

            int notRecognized = recordsToValidate.Length;
            for(int k = 0; k<recordsToValidate.Length; k++)
            {
                var recordToValidate = validationSamples.Records[k];
                var result = classifier.Predict(recordToValidate, trainingSamples.Records).ToArray();
                var sortedResult = result.OrderBy(x => x.Distance).First();
                if(sortedResult.Number != recordToValidate.Number)
                {
                    Console.WriteLine($"Probably it is {sortedResult.Number}, it's distance is {Math.Floor(sortedResult.Distance)}");
                    Console.WriteLine($"It should be: {recordToValidate.Number}");
                    notRecognized--;
                    
                }  
            }
            decimal accuracy = (notRecognized / 500m)*100;
            Console.WriteLine($"Accuracy: {accuracy}%");
            Console.ReadLine();




        }

    }
}
