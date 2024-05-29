using UnityEngine;
using UnityEngine.UI;

namespace Controller.Handler.SettingsHandler
{
    /// <summary>
    /// Singleton class responsible for managing System Settings Panel.
    /// </summary>
    public class SystemSettingsHandler : MonoBehaviour
    {
        // SINGLETON:
        private static SystemSettingsHandler _instance;
        public static SystemSettingsHandler Instance => _instance;

        // SERIALIZE FIELDS:
        [Header("System Settings Panel:")]
        [SerializeField] private GameObject systemSettingsPanel;
        
        [Header("Global Settings:")]
        [SerializeField] private Slider steeringWheelFeedbackSlider;
        [SerializeField] private Slider steeringWheelSensitivitySlider;
        [SerializeField] private Slider platformFeedbackSlider;
    
        [Header("Impaired Driver Settings:")]
        [SerializeField] private Toggle paraplegiaSupportToggle;
    
        [Header("Controller Input Settings:")]
        [SerializeField] private Button assignThrottleInputButton;
        [SerializeField] private Button assignBrakeInputButton;
        [SerializeField] private Button assignReverseInputButton;
        
        
        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            steeringWheelFeedbackSlider.onValueChanged.AddListener(delegate { SteeringWheelFeedbackSliderChanged(); });
            steeringWheelSensitivitySlider.onValueChanged.AddListener(delegate { SteeringWheelSensitivitySliderChanged(); });
            platformFeedbackSlider.onValueChanged.AddListener(delegate { PlatformFeedbackSliderChanged(); });
            paraplegiaSupportToggle.onValueChanged.AddListener(delegate { ParaplegiaSupportToggleChanged(); });
            assignThrottleInputButton.onClick.AddListener(delegate { AssignThrottleInputButtonClicked(); });
            assignBrakeInputButton.onClick.AddListener(delegate { AssignBrakeInputButtonClicked(); });
            assignReverseInputButton.onClick.AddListener(delegate { AssignReverseInputButtonClicked(); });
        }


        // METHODS:
        private void SteeringWheelFeedbackSliderChanged()
        {
            DataManager.SettingsDataInstance.SteeringWheelFeedbackSliderValue = steeringWheelFeedbackSlider.value;
        }


        private void SteeringWheelSensitivitySliderChanged()
        {
            DataManager.SettingsDataInstance.SteeringWheelSensitivitySliderValue = steeringWheelSensitivitySlider.value;
        }


        private void PlatformFeedbackSliderChanged()
        {
            DataManager.SettingsDataInstance.PlatformFeedbackSliderValue = platformFeedbackSlider.value;
        }


        private void ParaplegiaSupportToggleChanged()
        {
            DataManager.SettingsDataInstance.ParaplegiaSupportToggleValue = paraplegiaSupportToggle.isOn;
        }
    
    
        private void AssignThrottleInputButtonClicked()
        {
            // TODO
        }


        private void AssignBrakeInputButtonClicked()
        {
            // TODO
        }


        private void AssignReverseInputButtonClicked()
        {
            // TODO
        }


        public void Disable()
        {
            steeringWheelFeedbackSlider.interactable = false;
            steeringWheelSensitivitySlider.interactable = false;
            platformFeedbackSlider.interactable = false;
            paraplegiaSupportToggle.interactable = false;
            assignThrottleInputButton.interactable = false;
            assignBrakeInputButton.interactable = false;
            assignReverseInputButton.interactable = false;
        }
        
        public void Enable()
        {
            steeringWheelFeedbackSlider.interactable = true;
            steeringWheelSensitivitySlider.interactable = true;
            platformFeedbackSlider.interactable = true;
            paraplegiaSupportToggle.interactable = true;
            assignThrottleInputButton.interactable = true;
            assignBrakeInputButton.interactable = true;
            assignReverseInputButton.interactable = true;
        }

        public void GetAll()
        {
            SteeringWheelFeedbackSliderChanged();
            SteeringWheelSensitivitySliderChanged();
            PlatformFeedbackSliderChanged();
            ParaplegiaSupportToggleChanged();
            AssignThrottleInputButtonClicked();
            AssignBrakeInputButtonClicked();
            AssignReverseInputButtonClicked();
        }

        public void SetAll()
        {
            steeringWheelFeedbackSlider.value = DataManager.SettingsDataInstance.SteeringWheelFeedbackSliderValue;
            steeringWheelFeedbackSlider.value = DataManager.SettingsDataInstance.SteeringWheelSensitivitySliderValue;
            platformFeedbackSlider.value = DataManager.SettingsDataInstance.PlatformFeedbackSliderValue;
            paraplegiaSupportToggle.isOn = DataManager.SettingsDataInstance.ParaplegiaSupportToggleValue;
            /*  TODO: implement
                = DataManager.SettingsDataInstance.CurrentThrottleInput;
                = DataManager.SettingsDataInstance.CurrentBrakeInput;
                = DataManager.SettingsDataInstance.CurrentReverseInput;
             */
        }

    }
}
