using System;
using Model;
using UnityEngine;

namespace Controller
{
    /// <summary>
    /// Singleton class responsible for managing Variables Data.
    /// Factory to instantiate all the Data Classes.
    /// </summary>
    public class DataManager : MonoBehaviour
    {
        // SINGLETON:
        private static DataManager _instance;
        
        // DATA INSTANCES:
        private static SettingsData _settingsDataInstance;
        
        
        private void Awake()
        {
            // Singleton pattern ensures only one instance exists
            if (_instance == null)
            {
                _instance = this;
                CreateVariables();  // Instantiate Data Classes
                DontDestroyOnLoad(gameObject); // Ensures the SettingsManager persists between scenes
            }
            else
            {
                Destroy(gameObject); // If another instance exists, destroy this one
            }
        }
        
        
        // Method to create instances of Data classes:
        private void CreateVariables()
        {
            _settingsDataInstance = SettingsData.GetInstance();
        }


        // PROPERTIES TO ACCESS DATA CLASSES INSTANCES:
        public static SettingsData SettingsDataInstance
        {
            get => _settingsDataInstance;
        }


        // DATA EXPORT METHODS:
        public void saveSettings()
        {
            throw new NotImplementedException();
        }

        public void loadSettings()
        {
            throw new NotImplementedException();
        }

        public void saveReport()
        {
            throw new NotImplementedException();
        }

        public void savePeripheralsData()
        {
            throw new NotImplementedException();
        }
        
    }
}