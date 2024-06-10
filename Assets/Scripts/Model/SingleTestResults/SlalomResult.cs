using System;

namespace Model.SingleTestResults
{
    public class SlalomResult : SingleTestResult
    {
        public SlalomResult(DateTime startingTime, TimeSpan elapsedTime, int executionNumber, int conesHit,
            float hitAccuracy, int directionErrors, float directionAccuracy, float totalAccuracy) : base(startingTime, elapsedTime, executionNumber)
        {
            _conesHit = conesHit;
            _hitAccuracy = hitAccuracy;
            _directionErrors = directionErrors;
            _directionAccuracy = directionAccuracy;
            _totalAccuracy = totalAccuracy;
        }
        
        private readonly int _conesHit;
        private readonly float _hitAccuracy;
        private readonly int _directionErrors;
        private readonly float _directionAccuracy;
        private readonly float _totalAccuracy;
        
    }
}