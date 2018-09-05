using System;
using System.Collections.Generic;
using System.Text;

namespace machineLearning.Interfaces
{
    interface IClassifier
    {
        void Train (IEnumerable<Record> TrainingSet);
        int Predict(int[] pixels, Record[] sampleRecords);
    }

    public class BasicClassifier : IClassifier
    {
        public int Predict(Record[], Record[] sampleRecords)
        {
           
        }

        public void Train(IEnumerable<Record> TrainingSet)
        {
            throw new NotImplementedException();
        }
    }
}
