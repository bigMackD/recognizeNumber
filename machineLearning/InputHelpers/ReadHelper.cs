using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace machineLearning.InputHelpers
{
    public class ReadHelper
    {
        public Record[] Records { get; set; }

        public ReadHelper(string path)
        {
            string[] data = File.ReadAllLines(path);
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
            records = recordsArray;
            this.Records = recordsArray;
        }
    }
}
