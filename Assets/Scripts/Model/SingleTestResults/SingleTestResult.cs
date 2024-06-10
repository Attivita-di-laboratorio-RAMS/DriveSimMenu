using System;

namespace Model.SingleTestResults
{
    public abstract class SingleTestResult
    {
        private readonly DateTime _startingTime;
        private readonly TimeSpan _elapsedTime;
        private readonly int _executionNumber;

        protected SingleTestResult(DateTime startingTime, TimeSpan elapsedTime, int executionNumber)
        {
            _startingTime = startingTime;
            _elapsedTime = elapsedTime;
            _executionNumber = executionNumber;
        }
    }
}