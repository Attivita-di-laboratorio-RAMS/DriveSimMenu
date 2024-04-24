using System;
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

        // SERIALIZE FIELDS:
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
            // Singleton pattern ensures only one instance exists
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject); // Ensures the SettingsManager persists between scenes
            }
            else
            {
                Destroy(gameObject); // If another instance exists, destroy this one
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
            throw new NotImplementedException();
        }


        private void AssignBrakeInputButtonClicked()
        {
            throw new NotImplementedException();
        }


        private void AssignReverseInputButtonClicked()
        {
            throw new NotImplementedException();
        }

    }
}
