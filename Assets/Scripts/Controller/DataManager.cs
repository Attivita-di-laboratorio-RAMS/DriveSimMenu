using System;
using System.IO;
using Model;
using Model.SingleTestResults;
using UnityEngine;
using System.Reflection;
using Controller.Handler.SettingsHandler;

namespace Controller
{
    /// <summary>
    /// Singleton class responsible for managing and exporting RESULTS and SETTINGS DATA.
    /// </summary>
    public class DataManager
    {
        // SINGLETON:
        private static DataManager _instance;
        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataManager();
                }
                return _instance;
            }
        }
        
        // ATTRIBUTES:
        private const string SettingsPath = @"Assets/SettingsOUT/";
        private const string ReportPath = @"Assets/ReportOUT/";
        private const string Extension = ".json";

        // SETTINGS DATA FACTORY
        // DataManager is responsible for the instantiation of SettingsData (done through REFLECTION because SettingsData has a private constructor).
        // Also, DataManager is the only one that can directly access SettingsData. 
        private static SettingsData _settingsDataInstance = SettingsDataInstance;
        public static SettingsData SettingsDataInstance     
        {
            get
            {
                if (_settingsDataInstance == null)
                {
                    ConstructorInfo settingsDataConstructor = typeof(SettingsData).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                    if (settingsDataConstructor != null)
                        _settingsDataInstance = (SettingsData)settingsDataConstructor.Invoke(null);
                }
                return _settingsDataInstance;
            }
        }
        
        
        // SETTINGS DATA FACTORY
        // DataManager is responsible for the instantiation of ResultsData (done through REFLECTION because ResultsData has a private constructor).
        // Also, DataManager is the only one that can directly access ResultsData. 
        private static ResultsData _resultsDataInstance = ResultsDataInstance;
        public static ResultsData ResultsDataInstance     
        {
            get
            {
                if (_resultsDataInstance == null)
                {
                    ConstructorInfo resultsDataConstructor = typeof(ResultsData).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                    if (resultsDataConstructor != null)
                        _resultsDataInstance = (ResultsData)resultsDataConstructor.Invoke(null);
                }
                return _resultsDataInstance;
            }
        }
        
        
        // RESULT DATA METHODS:
        public void AddSlalomResult(TimeSpan elapsedTime, int conesHit, float hitAccuracy, int directionErrors, float directionAccuracy, float totalAccuracy)
        {
            ResultsDataInstance.SlalomResults.Add(new SlalomResult((DateTime.Now-elapsedTime), elapsedTime, ResultsDataInstance.SlalomResults.Count, conesHit, hitAccuracy, directionErrors, directionAccuracy, totalAccuracy));
        }
        
        public void AddLineKeepingResult(TimeSpan elapsedTime, float maxDeviation, float errorMean, float standardDeviation, float errorRms)
        {
            ResultsDataInstance.LineKeepingResults.Add(new LineKeepingResult((DateTime.Now-elapsedTime), elapsedTime, ResultsDataInstance.LineKeepingResults.Count, maxDeviation, errorMean, standardDeviation, errorRms));
        }
        
        public void AddReactionTestResult(bool outcome, TimeSpan reactionTime)
        {
            ResultsDataInstance.ReactionTestResults.Add(new ReactionTestResult(DateTime.Now, ResultsDataInstance.ReactionTestResults.Count, outcome, reactionTime));
        }
        public void AddReactionTestResult(bool outcome)
        {
            AddReactionTestResult(outcome, TimeSpan.Zero);
        }
        
        public void AddSpeedControlResult(TimeSpan elapsedTime, float maxDeviation, float errorMean, float standardDeviation, float errorRms)
        {
            ResultsDataInstance.SpeedControlResults.Add(new SpeedControlResults((DateTime.Now-elapsedTime), elapsedTime, ResultsDataInstance.SpeedControlResults.Count, maxDeviation, errorMean, standardDeviation, errorRms));
        }


        
        // DATA EXPORT METHODS:
        public void SaveSettings(string fileName)
        {
            GameSettingsHandler.Instance.ForceUpdate();
            SystemSettingsHandler.Instance.ForceUpdate();
            var content = JsonUtility.ToJson(SettingsDataInstance, true);
            File.WriteAllText(SettingsPath + fileName + Extension, content);
        }

        public void LoadSettings(string fileName)
        {
            throw new NotImplementedException();
        }

        public void SaveReport(string fileName)
        {
            var content = JsonUtility.ToJson(ResultsDataInstance, true);
            File.WriteAllText(ReportPath + fileName + Extension, content);
        }
    }
}