using System;

namespace Domain.Results
{
    public class SlalomResult
    {
        public SlalomResult(DateTime startingTime, TimeSpan elapsedTime, int executionNumber, int conesHit, float hitAccuracy, int directionErrors, float directionAccuracy, float totalAccuracy)
        {
            _startingTime = startingTime;
            _elapsedTime = elapsedTime;
            _executionNumber = executionNumber;
            _conesHit = conesHit;
            _hitAccuracy = hitAccuracy;
            _directionAccuracy = directionAccuracy;
            _totalAccuracy = totalAccuracy;
        }
        
        private DateTime _startingTime;
        private TimeSpan _elapsedTime;
        private int _executionNumber;
        private int _conesHit;
        private float _hitAccuracy;
        private int _directionErrors;
        private float _directionAccuracy;
        private float _totalAccuracy;

    }
}