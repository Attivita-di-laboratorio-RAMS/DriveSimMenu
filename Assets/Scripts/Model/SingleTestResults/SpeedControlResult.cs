using System;

namespace Model.SingleTestResults
{
    public class SpeedControlResult : SingleTestResult
    {
        public SpeedControlResult(DateTime startingTime, TimeSpan elapsedTime, int executionNumber, float maxDeviation,
            float errorMean, float standardDeviation, float errorRms) : base(startingTime, elapsedTime, executionNumber)
        {
            _maxDeviation = maxDeviation;
            _errorMean = errorMean;
            _standardDeviation = standardDeviation;
            _errorRms = errorRms;
        }
        
        private readonly float _maxDeviation;
        private readonly float _errorMean;
        private readonly float _standardDeviation;
        private readonly float _errorRms;

    }
}