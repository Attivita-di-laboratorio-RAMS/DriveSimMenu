using System;

namespace Model.Results
{
    public class SpeedControlResults
    {
        public SpeedControlResults(DateTime startingTime, TimeSpan elapsedTime, int executionNumber, float maxDeviation,
            float errorMean, float standardDeviation, float errorRms)
        {
            _startingTime = startingTime;
            _elapsedTime = elapsedTime;
            _executionNumber = executionNumber;
            _maxDeviation = maxDeviation;
            _errorMean = errorMean;
            _standardDeviation = standardDeviation;
            _errorRms = errorRms;
        }

        private readonly DateTime _startingTime;
        private readonly TimeSpan _elapsedTime;
        private readonly int _executionNumber;
        private readonly float _maxDeviation;
        private readonly float _errorMean;
        private readonly float _standardDeviation;
        private readonly float _errorRms;

        public DateTime StartingTime => _startingTime;

        public TimeSpan ElapsedTime => _elapsedTime;

        public int ExecutionNumber => _executionNumber;

        public float MaxDeviation => _maxDeviation;

        public float ErrorMean => _errorMean;

        public float StandardDeviation => _standardDeviation;

        public float ErrorRms => _errorRms;
    }
}