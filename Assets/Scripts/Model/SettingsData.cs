
namespace Model
{
    /// <summary>
    /// Singleton class responsible for managing Settings Variables.
    /// </summary>
    public class SettingsData
    {
        // SINGLETON:
        private static SettingsData _instance;
        // PRIVATE CONSTRUCTOR:
        private SettingsData() {}
        
        // SYSTEM STATUS:
        private StatusEnum _systemStatus;
        
        // GAME SETTINGS VARIABLES:
        private bool _slalomActivateToggleValue;
        private float _slalomActivateSliderValue;
        private bool _slalomDisturbancesToggleValue;
        private float _slalomDisturbancesSliderValue;
        private bool _lineKeepingActivateToggleValue;
        private bool _lineKeepingDisturbancesToggleValue;
        private float _lineKeepingDisturbancesSliderValue;
        private bool _reactionTestActivateToggleValue;
        private bool _speedControlActivateToggleValue;
        private float _speedControlActivateSliderValue;
        
        // SYSTEM SETTINGS VARIABLES:
        private float _steeringWheelFeedbackSliderValue;
        private float _steeringWheelSensitivitySliderValue;
        private float _platformFeedbackSliderValue;
        private bool _paraplegiaSupportToggleValue;
        private string _currentThrottleInput;
        private string _currentBrakeInput;
        private string _currentReverseInput;
        
        
        // Method to get the singleton instance of SettingsData (factory pattern):
        public static SettingsData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SettingsData();
            }
            return _instance;
        }
        
        
        // PROPERTY ACCESSORS:
        public StatusEnum SystemStatus
        {
            get => _systemStatus;
            set => _systemStatus = value;
        }

        public bool SlalomActivateToggleValue
        {
            get => _slalomActivateToggleValue;
            set => _slalomActivateToggleValue = value;
        }

        public float SlalomActivateSliderValue
        {
            get => _slalomActivateSliderValue;
            set => _slalomActivateSliderValue = value;
        }

        public bool SlalomDisturbancesToggleValue
        {
            get => _slalomDisturbancesToggleValue;
            set => _slalomDisturbancesToggleValue = value;
        }

        public float SlalomDisturbancesSliderValue
        {
            get => _slalomDisturbancesSliderValue;
            set => _slalomDisturbancesSliderValue = value;
        }

        public bool LineKeepingActivateToggleValue
        {
            get => _lineKeepingActivateToggleValue;
            set => _lineKeepingActivateToggleValue = value;
        }

        public bool LineKeepingDisturbancesToggleValue
        {
            get => _lineKeepingDisturbancesToggleValue;
            set => _lineKeepingDisturbancesToggleValue = value;
        }

        public float LineKeepingDisturbancesSliderValue
        {
            get => _lineKeepingDisturbancesSliderValue;
            set => _lineKeepingDisturbancesSliderValue = value;
        }

        public bool ReactionTestActivateToggleValue
        {
            get => _reactionTestActivateToggleValue;
            set => _reactionTestActivateToggleValue = value;
        }

        public bool SpeedControlActivateToggleValue
        {
            get => _speedControlActivateToggleValue;
            set => _speedControlActivateToggleValue = value;
        }

        public float SpeedControlActivateSliderValue
        {
            get => _speedControlActivateSliderValue;
            set => _speedControlActivateSliderValue = value;
        }

        public float SteeringWheelFeedbackSliderValue
        {
            get => _steeringWheelFeedbackSliderValue;
            set => _steeringWheelFeedbackSliderValue = value;
        }

        public float SteeringWheelSensitivitySliderValue
        {
            get => _steeringWheelSensitivitySliderValue;
            set => _steeringWheelSensitivitySliderValue = value;
        }

        public float PlatformFeedbackSliderValue
        {
            get => _platformFeedbackSliderValue;
            set => _platformFeedbackSliderValue = value;
        }

        public bool ParaplegiaSupportToggleValue
        {
            get => _paraplegiaSupportToggleValue;
            set => _paraplegiaSupportToggleValue = value;
        }

        public string CurrentThrottleInput
        {
            get => _currentThrottleInput;
            set => _currentThrottleInput = value;
        }

        public string CurrentBrakeInput
        {
            get => _currentBrakeInput;
            set => _currentBrakeInput = value;
        }

        public string CurrentReverseInput
        {
            get => _currentReverseInput;
            set => _currentReverseInput = value;
        }
    }
}
