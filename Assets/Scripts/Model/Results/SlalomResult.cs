using System;

namespace Model.Results
{
    public class SlalomResult
    {
        public SlalomResult(DateTime startingTime, TimeSpan elapsedTime, int executionNumber, int conesHit,
            float hitAccuracy, int directionErrors, float directionAccuracy, float totalAccuracy)
        {
            _startingTime = startingTime;
            _elapsedTime = elapsedTime;
            _executionNumber = executionNumber;
            _conesHit = conesHit;
            _hitAccuracy = hitAccuracy;
            _directionErrors = directionErrors;
            _directionAccuracy = directionAccuracy;
            _totalAccuracy = totalAccuracy;
        }

        private readonly DateTime _startingTime;
        private readonly TimeSpan _elapsedTime;
        private readonly int _executionNumber;
        private readonly int _conesHit;
        private readonly float _hitAccuracy;
        private readonly int _directionErrors;
        private readonly float _directionAccuracy;
        private readonly float _totalAccuracy;

        public DateTime StartingTime => _startingTime;

        public TimeSpan ElapsedTime => _elapsedTime;

        public int ExecutionNumber => _executionNumber;

        public int ConesHit => _conesHit;

        public float HitAccuracy => _hitAccuracy;

        public int DirectionErrors => _directionErrors;

        public float DirectionAccuracy => _directionAccuracy;

        public float TotalAccuracy => _totalAccuracy;
    }
}