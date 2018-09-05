using System;
using System.Collections.Generic;
using System.Text;

namespace machineLearning.Repositories
{
    public class ResultsRepository
    {
        private static List<Result> _allResults = new List<Result>();

        public void Add(Result result)
        {
            _allResults.Add(result);
        }

        public IEnumerable<Result> GetResults()
        {
            return _allResults;
        }
       
    }
}
