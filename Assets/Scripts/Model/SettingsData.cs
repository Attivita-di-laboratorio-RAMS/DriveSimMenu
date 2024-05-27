
using System;
using UnityEngine;

namespace Model
{
    /// <summary>
    /// Singleton class responsible for managing Settings Variables.
    /// </summary>
    [Serializable]
    public class SettingsData
    {
        // PRIVATE CONSTRUCTOR:
        private SettingsData()
        {
        }

        // SYSTEM STATUS:
        private StatusEnum _systemStatus;
        
        // CURRENT USER:
        private string _username = "default";
        
        // GAME SETTINGS VARIABLES:
        [SerializeField] private bool slalomActivateToggleValue;
        [SerializeField] private float slalomActivateSliderValue;
        [SerializeField] private bool slalomDisturbancesToggleValue;
        [SerializeField] private float slalomDisturbancesSliderValue;
        [SerializeField] private bool lineKeepingActivateToggleValue;
        [SerializeField] private bool lineKeepingDisturbancesToggleValue;
        [SerializeField] private float lineKeepingDisturbancesSliderValue;
        [SerializeField] private bool reactionTestActivateToggleValue;
        [SerializeField] private bool speedControlActivateToggleValue;
        [SerializeField] private float speedControlActivateSliderValue;
        
        // SYSTEM SETTINGS VARIABLES:
        [SerializeField] private float steeringWheelFeedbackSliderValue;
        [SerializeField] private float steeringWheelSensitivitySliderValue;
        [SerializeField] private float platformFeedbackSliderValue;
        [SerializeField] private bool paraplegiaSupportToggleValue;
        [SerializeField] private string currentThrottleInput;
        [SerializeField] private string currentBrakeInput;
        [SerializeField] private string currentReverseInput;
        
        
        // PROPERTY ACCESSORS:
        public string Username
        {
            get => _username;
            set => _username = value;
        }
        
        public StatusEnum SystemStatus
        {
            get => _systemStatus;
            set => _systemStatus = value;
        }

        public bool SlalomActivateToggleValue
        {
            get => slalomActivateToggleValue;
            set => slalomActivateToggleValue = value;
        }

        public float SlalomActivateSliderValue
        {
            get => slalomActivateSliderValue;
            set => slalomActivateSliderValue = value;
        }

        public bool SlalomDisturbancesToggleValue
        {
            get => slalomDisturbancesToggleValue;
            set => slalomDisturbancesToggleValue = value;
        }

        public float SlalomDisturbancesSliderValue
        {
            get => slalomDisturbancesSliderValue;
            set => slalomDisturbancesSliderValue = value;
        }

        public bool LineKeepingActivateToggleValue
        {
            get => lineKeepingActivateToggleValue;
            set => lineKeepingActivateToggleValue = value;
        }

        public bool LineKeepingDisturbancesToggleValue
        {
            get => lineKeepingDisturbancesToggleValue;
            set => lineKeepingDisturbancesToggleValue = value;
        }

        public float LineKeepingDisturbancesSliderValue
        {
            get => lineKeepingDisturbancesSliderValue;
            set => lineKeepingDisturbancesSliderValue = value;
        }

        public bool ReactionTestActivateToggleValue
        {
            get => reactionTestActivateToggleValue;
            set => reactionTestActivateToggleValue = value;
        }

        public bool SpeedControlActivateToggleValue
        {
            get => speedControlActivateToggleValue;
            set => speedControlActivateToggleValue = value;
        }

        public float SpeedControlActivateSliderValue
        {
            get => speedControlActivateSliderValue;
            set => speedControlActivateSliderValue = value;
        }

        public float SteeringWheelFeedbackSliderValue
        {
            get => steeringWheelFeedbackSliderValue;
            set => steeringWheelFeedbackSliderValue = value;
        }

        public float SteeringWheelSensitivitySliderValue
        {
            get => steeringWheelSensitivitySliderValue;
            set => steeringWheelSensitivitySliderValue = value;
        }

        public float PlatformFeedbackSliderValue
        {
            get => platformFeedbackSliderValue;
            set => platformFeedbackSliderValue = value;
        }

        public bool ParaplegiaSupportToggleValue
        {
            get => paraplegiaSupportToggleValue;
            set => paraplegiaSupportToggleValue = value;
        }

        public string CurrentThrottleInput
        {
            get => currentThrottleInput;
            set => currentThrottleInput = value;
        }

        public string CurrentBrakeInput
        {
            get => currentBrakeInput;
            set => currentBrakeInput = value;
        }

        public string CurrentReverseInput
        {
            get => currentReverseInput;
            set => currentReverseInput = value;
        }

    }
}
