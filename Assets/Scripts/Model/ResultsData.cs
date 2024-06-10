using System;
using System.Collections.Generic;
using Model.SingleTestResults;
using UnityEngine;

namespace Model
{
    /// <summary>
    /// Singleton class responsible for managing User Results.
    /// </summary>
    [Serializable]
    public class ResultsData
    {
        // PRIVATE CONSTRUCTOR:
        private ResultsData()
        {
        }
        
        // EXERGAMES RESULTS:
        [SerializeField] private List<SlalomResult> _slalomResults = new List<SlalomResult>();
        [SerializeField] private List<LineKeepingResult> _lineKeepingResults = new List<LineKeepingResult>();
        [SerializeField] private List<ReactionTestResult> _reactionTestResults = new List<ReactionTestResult>();
        [SerializeField] private List<SpeedControlResult> _speedControlResults = new List<SpeedControlResult>();

        public List<SlalomResult> SlalomResults
        {
            get => _slalomResults;
            set => _slalomResults = value;
        }

        public List<LineKeepingResult> LineKeepingResults
        {
            get => _lineKeepingResults;
            set => _lineKeepingResults = value;
        }

        public List<ReactionTestResult> ReactionTestResults
        {
            get => _reactionTestResults;
            set => _reactionTestResults = value;
        }

        public List<SpeedControlResult> SpeedControlResults
        {
            get => _speedControlResults;
            set => _speedControlResults = value;
        }
    }
}