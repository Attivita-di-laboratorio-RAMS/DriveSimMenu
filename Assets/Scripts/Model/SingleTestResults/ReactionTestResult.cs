using System;

namespace Model.SingleTestResults
{
    public class ReactionTestResult : SingleTestResult
    {
        public ReactionTestResult(DateTime startingTime, int executionNumber, bool outcome, TimeSpan reactionTime) : base(startingTime, reactionTime, executionNumber)
        {
            _outcome = outcome;
        }

        private readonly bool _outcome;

    }
}