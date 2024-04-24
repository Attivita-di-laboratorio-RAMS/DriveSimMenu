using System;
using System.Collections.Generic;
using Model.Results;

namespace Controller
{
    /// <summary>
    /// Singleton class responsible for managing User Results.
    /// </summary>
    public class ResultsManager
    {
        // SINGLETON:
        private static ResultsManager _instance;

        // PRIVATE CONSTRUCTOR:
        private ResultsManager()
        {
        }

        // EXERGAMES RESULTS:
        private static List<SlalomResult> _slalomResults = new List<SlalomResult>();
        private static List<LineKeepingResult> _lineKeepingResults = new List<LineKeepingResult>();
        private static List<ReactionTestResult> _reactionTestResults = new List<ReactionTestResult>();
        private static List<SpeedControlResults> _speedControlResults = new List<SpeedControlResults>();


        // SINGLETON:
        public static ResultsManager GetInstance()
        {
            // If the instance is null, create a new instance.
            if (_instance == null)
            {
                _instance = new ResultsManager();
            }

            // Return the instance.
            return _instance;
        }

        
        public void AddSlalomResult(TimeSpan elapsedTime, int conesHit, float hitAccuracy, int directionErrors, float directionAccuracy, float totalAccuracy)
        {
            _slalomResults.Add(new SlalomResult((DateTime.Now-elapsedTime), elapsedTime, _slalomResults.Count, conesHit, hitAccuracy, directionErrors, directionAccuracy, totalAccuracy));
        }
        
        public void AddLineKeepingResult(TimeSpan elapsedTime, float maxDeviation, float errorMean, float standardDeviation, float errorRms)
        {
            _lineKeepingResults.Add(new LineKeepingResult((DateTime.Now-elapsedTime), elapsedTime, _lineKeepingResults.Count, maxDeviation, errorMean, standardDeviation, errorRms));
        }
        
        public void AddReactionTestResult(bool outcome, TimeSpan reactionTime)
        {
            _reactionTestResults.Add(new ReactionTestResult(DateTime.Now, _reactionTestResults.Count, outcome, reactionTime));
        }
        public void AddReactionTestResult(bool outcome)
        {
            AddReactionTestResult(outcome, TimeSpan.Zero);
        }
        
        public void AddSpeedControlResult(TimeSpan elapsedTime, float maxDeviation, float errorMean, float standardDeviation, float errorRms)
        {
            _speedControlResults.Add(new SpeedControlResults((DateTime.Now-elapsedTime), elapsedTime, _speedControlResults.Count, maxDeviation, errorMean, standardDeviation, errorRms));
        }
    }
}