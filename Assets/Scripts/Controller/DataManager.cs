using System;
using System.Data;
using System.IO;
using System.Linq;
using Model;
using Model.SingleTestResults;
using UnityEngine;
using System.Reflection;
using Controller.Handler.SettingsHandler;

namespace Controller
{
    /// <summary>
    /// Singleton class responsible for managing and exporting RESULTS, SETTINGS DATA and PERIPHERAL DATA.
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
        private const string PeripheralDataPath = @"Assets/PeripheralDataOUT/";
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
        
        
        // RESULT DATA FACTORY
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
        
        
        // PERIPHERAL DATA FACTORY
        // DataManager is responsible for the instantiation of PeripheralData (done through REFLECTION because PeripheralData has a private constructor).
        private static PeripheralData _peripheralDataInstance = PeripheralDataInstance;
        public static PeripheralData PeripheralDataInstance     
        {
            get
            {
                if (_peripheralDataInstance == null)
                {
                    ConstructorInfo peripheralDataConstructor = typeof(PeripheralData).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                    if (peripheralDataConstructor != null)
                        _peripheralDataInstance = (PeripheralData)peripheralDataConstructor.Invoke(null);
                }
                return _peripheralDataInstance;
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
        
        
        // PERIPHERAL DATA METHODS:
        public void InitializePeripheralData(string[] variableNames)
        {
            PeripheralDataInstance.InitializePeripheralData(variableNames);
        }

        public void AddPeripheralData(float[] variables)
        {
            PeripheralDataInstance.AddPeripheralData(variables);
        }


        
        // DATA EXPORT METHODS:
        public void SaveSettings(string fileName)
        {
            GameSettingsHandler.Instance.GetAll();
            SystemSettingsHandler.Instance.GetAll();
            var content = JsonUtility.ToJson(SettingsDataInstance, true);
            File.WriteAllText(SettingsPath + fileName + Extension, content);
        }


        public void LoadSettings(string fileName)
        {
            var fileStr = File.ReadAllText(SettingsPath + fileName + Extension);
            
            char[] delimiterChars = { '{', '}', '"', ' ', ',', ':', '\t', '\n' };
            string[] savedSettings = fileStr.Split(delimiterChars);     //parse file into a string array
            savedSettings = savedSettings.Where(x => !string.IsNullOrEmpty(x)).ToArray();   //remove empty strings

           /* DEBUG PRINT:
            int i = 0;
            foreach (var word in savedSettings)
            {
                i++;
                Debug.Log(i + ": " + word);
            }
            */
            
            DataManager.SettingsDataInstance.SlalomActivateToggleValue = ToBool(savedSettings[1]);
            DataManager.SettingsDataInstance.SlalomActivateSliderValue = float.Parse(savedSettings[3]);
            DataManager.SettingsDataInstance.SlalomDisturbancesToggleValue = ToBool(savedSettings[5]);
            DataManager.SettingsDataInstance.SlalomDisturbancesSliderValue = float.Parse(savedSettings[7]);
            DataManager.SettingsDataInstance.LineKeepingActivateToggleValue = ToBool(savedSettings[9]);
            DataManager.SettingsDataInstance.LineKeepingDisturbancesToggleValue = ToBool(savedSettings[11]);
            DataManager.SettingsDataInstance.LineKeepingDisturbancesSliderValue = float.Parse(savedSettings[13]);
            DataManager.SettingsDataInstance.ReactionTestActivateToggleValue = ToBool(savedSettings[15]);
            DataManager.SettingsDataInstance.SpeedControlActivateToggleValue = ToBool(savedSettings[17]);
            DataManager.SettingsDataInstance.SpeedControlActivateSliderValue = float.Parse(savedSettings[19]);
            DataManager.SettingsDataInstance.SteeringWheelFeedbackSliderValue = float.Parse(savedSettings[21]);
            DataManager.SettingsDataInstance.SteeringWheelSensitivitySliderValue = float.Parse(savedSettings[23]);
            DataManager.SettingsDataInstance.PlatformFeedbackSliderValue = float.Parse(savedSettings[25]);
            DataManager.SettingsDataInstance.ParaplegiaSupportToggleValue = ToBool(savedSettings[27]);
            
            /* TODO: implement (ora se non sono impostati controlli le strighe sono vuote e vengono rimosse, questo genera ArrayOutOfBound)
            DataManager.SettingsDataInstance.CurrentThrottleInput = savedSettings[29];
            DataManager.SettingsDataInstance.CurrentBrakeInput = savedSettings[31];
            DataManager.SettingsDataInstance.CurrentReverseInput = savedSettings[33];
            */

            GameSettingsHandler.Instance.SetAll();
            SystemSettingsHandler.Instance.SetAll();
            
        }

        public void SaveReport(string fileName)
        {
            var content = JsonUtility.ToJson(ResultsDataInstance, true);
            File.WriteAllText(ReportPath + fileName + Extension, content);
        }
        
        
        public void SavePeripheralData(string fileName)
        {
            var content = JsonUtility.ToJson(ResultsDataInstance, true);
            File.WriteAllText(ReportPath + fileName + Extension, content);

            DataTable myTable = PeripheralDataInstance.PeripheralDataTable;
            myTable.WriteXml(PeripheralDataPath + fileName);
        }
        

        private bool ToBool(string str)
        {
            if (string.Compare(str, "true") == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}