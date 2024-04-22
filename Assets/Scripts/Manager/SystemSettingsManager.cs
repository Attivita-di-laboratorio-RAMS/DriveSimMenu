using System;
using UnityEngine;
using UnityEngine.UI;

namespace Manager
{
    /// <summary>
    /// Singleton class responsible for managing System Settings Panel.
    /// </summary>
    public class SystemSettingsManager : MonoBehaviour
    {
        // SINGLETON:
        private static SystemSettingsManager _instance;

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

    
        // SETTINGS VARIABLES
        private float _steeringWheelFeedbackSliderValue;
        private float _steeringWheelSensitivitySliderValue;
        private float _platformFeedbackSliderValue;
        private bool _paraplegiaSupportToggleValue;
        private string _currentThrottleInput;
        private string _currentBrakeInput;
        private string _currentReverseInput;


    
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
            //REMOVE COMMENT GameManager.wheelManager.DefaultMagnitude = (int)(steeringWheelFeedbackSlider.value * 10000);
            //REMOVE COMMENT GameManager.wheelManager.RequestEffect(GameManager.wheelManager.defaultEffect, GameManager.wheelManager.DefaultMagnitude);
        }


        private void SteeringWheelSensitivitySliderChanged()
        {
            //REMOVE COMMENT GameManager.wheelManager.sensitivity = (int)(steeringWheelSensitivitySlider.value * 5);
        }


        private void PlatformFeedbackSliderChanged()
        {
            //REMOVE COMMENT GameManager.platformManager.GAIN = platformFeedbackSlider.value;
        }


        private void ParaplegiaSupportToggleChanged()
        {
            //REMOVE COMMENT GameManager.PARAPLEGIA = paraplegiaSupportToggle.isOn;
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
