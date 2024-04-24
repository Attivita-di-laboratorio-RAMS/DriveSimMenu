using System;
using System.Collections.Generic;
using Domain.Results;

namespace Domain
{
    /// <summary>
    /// Singleton class responsible for managing User Results.
    /// </summary>
    public class ResultSet
    {
        // SINGLETON:
        private static ResultSet _instance;

        // PRIVATE CONSTRUCTOR:
        private ResultSet()
        {
        }

        // EXERGAMES RESULTS:
        private static List<SlalomResult> _slalomResults = new List<SlalomResult>();
        private static List<LineKeepingResult> _lineKeepingResults = new List<LineKeepingResult>();
        private static List<ReactionTestResult> _reactionTestResults = new List<ReactionTestResult>();
        private static List<SpeedControlResults> _speedControlResults = new List<SpeedControlResults>();


        // SINGLETON:
        public static ResultSet GetInstance()
        {
            // If the instance is null, create a new instance.
            if (_instance == null)
            {
                _instance = new ResultSet();
            }

            // Return the instance.
            return _instance;
        }

        // METHOD TO ADD A RESULT TO THE RESULT SET:
        public void AddSlalomResult(TimeSpan elapsedTime, int conesHit, float hitAccuracy, int directionErrors, float directionAccuracy, float totalAccuracy)
        {
            _slalomResults.Add(new SlalomResult((DateTime.Now-elapsedTime), elapsedTime, _slalomResults.Count, conesHit, hitAccuracy, directionErrors, directionAccuracy, totalAccuracy));
        }

    }
}