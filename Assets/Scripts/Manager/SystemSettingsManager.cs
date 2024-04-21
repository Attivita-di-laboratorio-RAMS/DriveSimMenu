using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField] private TextMeshProUGUI steeringWheelFeedbackSliderText;
    [SerializeField] private Slider steeringWheelSensitivitySlider;
    [SerializeField] private TextMeshProUGUI steeringWheelSensitivitySliderText;
    [SerializeField] private Slider platformFeedbackSlider;
    [SerializeField] private TextMeshProUGUI platformFeedbackSliderText;
    
    [Header("Impaired Driver Settings:")]
    [SerializeField] private Toggle paraplegiaSupportToggle;
    
    [Header("Controller Input Settings:")]


    
    // SETTINGS VARIABLES
    private float _steeringWheelFeedbackSliderValue;
    private float _steeringWheelSensitivitySliderValue;
    private float _platformFeedbackSliderValue;
    private bool _paraplegiaSupportToggleValue;


    
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
    }


    // METHODS:
    private void SteeringWheelFeedbackSliderChanged()
    {
        GameManager.wheelManager.DefaultMagnitude = (int)(steeringWheelFeedbackSlider.value * 10000);
        GameManager.wheelManager.RequestEffect(GameManager.wheelManager.defaultEffect, GameManager.wheelManager.DefaultMagnitude);
    }


    private void SteeringWheelSensitivitySliderChanged()
    {
        GameManager.wheelManager.sensitivity = (int)(steeringWheelSensitivitySlider.value * 5);
    }


    private void PlatformFeedbackSliderChanged()
    {
        GameManager.platformManager.GAIN = platformFeedbackSlider.value;
    }


    private void ParaplegiaSupportToggleChanged()
    {
        GameManager.PARAPLEGIA = paraplegiaSupportToggle.isOn;
    }

}
