using System;

namespace Model.Results
{
    public class ReactionTestResult
    {
        public ReactionTestResult(DateTime startingTime, int executionNumber, bool outcome, TimeSpan reactionTime)
        {
            _startingTime = startingTime;
            _executionNumber = executionNumber;
            _outcome = outcome;
            _reactionTime = reactionTime;
        }

        private readonly DateTime _startingTime;
        private readonly TimeSpan _reactionTime;
        private readonly int _executionNumber;
        private readonly bool _outcome;

        public DateTime StartingTime => _startingTime;

        public TimeSpan ReactionTime => _reactionTime;

        public int ExecutionNumber => _executionNumber;

        public bool Outcome => _outcome;
    }
}