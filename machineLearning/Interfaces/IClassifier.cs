using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using machineLearning.Repositories;

namespace machineLearning.Interfaces
{
    interface IClassifier
    {
        void Train (IEnumerable<Record> TrainingSet);
        IEnumerable<Result> Predict(Record sampleToValidateRecord, Record[] sampleRecords);
    }

    public class BasicClassifier : IClassifier
    {
        IDistance distance = new Distance();
        ResultsRepository _repository = new ResultsRepository();
        public IEnumerable<Result> Predict(Record sampleToValidateRecord, Record[] sampleRecords) 
        {
            //throw new NotImplementedException();
            var result = sampleRecords.Select(X => distance.Between(X, sampleToValidateRecord));
            return result;
        }

        public void Train(IEnumerable<Record> TrainingSet)
        {
            throw new NotImplementedException();
        }
    }
}
