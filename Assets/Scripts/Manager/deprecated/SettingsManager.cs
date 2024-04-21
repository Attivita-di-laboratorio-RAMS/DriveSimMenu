using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Singleton class responsible for managing game settings.
/// </summary>
public class SettingsManager : MonoBehaviour
{
    // SINGLETON:
    private static SettingsManager _instance;

    // SERIALIZE FIELDS:
    #region Account Settings Panel
    [Header("Account Settings Panel:")]
    #endregion

    #region Game Settings Panel
    [Header("Game Settings Panel:")]
    [SerializeField] private Toggle slalomActivateToggle;
    [SerializeField] private Slider slalomActivateSlider;
    [SerializeField] private Toggle slalomDisturbancesToggle;
    [SerializeField] private Slider slalomDisturbancesSlider;
    [SerializeField] private Toggle lineKeepingActivateToggle;
    [SerializeField] private Toggle lineKeepingDisturbancesToggle;
    [SerializeField] private Slider lineKeepingDisturbancesSlider;
    [SerializeField] private Toggle reactionTestActivateToggle;
    [SerializeField] private Toggle speedControlActivateToggle;
    [SerializeField] private Slider speedControlActivateSlider;
    #endregion

    #region System Settings Panel
    [Header("System Settings Panel:")]
    [SerializeField] private Slider steeringWheelFeedbackSlider;
    [SerializeField] private Slider steeringWheelSensitivitySlider;
    [SerializeField] private Slider platformFeedbackSlider;
    [SerializeField] private Toggle paraplegiaSupportToggle;
    #endregion

    #region System Report Panel
    [Header("System Settings Panel:")]
    #endregion

    
    // SETTINGS VARIABLES
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
        // CONFIGURE LISTENERS:
        slalomActivateToggle.onValueChanged.AddListener(delegate { SlalomActivateToggleChanged(); });
        slalomActivateSlider.onValueChanged.AddListener(delegate { SlalomActivateSliderChanged(); });
        slalomDisturbancesToggle.onValueChanged.AddListener(delegate { SlalomDisturbancesToggleChanged(); });
        slalomDisturbancesSlider.onValueChanged.AddListener(delegate { SlalomDisturbancesSliderChanged(); });
        lineKeepingActivateToggle.onValueChanged.AddListener(delegate { LineKeepingActivateToggleChanged(); });
        lineKeepingDisturbancesToggle.onValueChanged.AddListener(delegate { LineKeepingDisturbancesToggleChanged(); });
        lineKeepingDisturbancesSlider.onValueChanged.AddListener(delegate { LineKeepingDisturbancesSliderChanged(); });
        reactionTestActivateToggle.onValueChanged.AddListener(delegate { ReactionTestActivateToggleChanged(); });
        speedControlActivateToggle.onValueChanged.AddListener(delegate { SpeedControlActivateToggleChanged(); });
        speedControlActivateSlider.onValueChanged.AddListener(delegate { SpeedControlActivateSliderChanged(); });

        steeringWheelFeedbackSlider.onValueChanged.AddListener(delegate { SteeringWheelFeedbackSliderChanged(); });
        steeringWheelSensitivitySlider.onValueChanged.AddListener(delegate { SteeringWheelSensitivitySliderChanged(); });
        platformFeedbackSlider.onValueChanged.AddListener(delegate { PlatformFeedbackSliderChanged(); });

        paraplegiaSupportToggle.onValueChanged.AddListener(delegate { ParaplegiaSupportToggleChanged(); });
    }


    // METHODS:
    private static void SlalomActivateToggleChanged()
    {
    }


    private static void SlalomActivateSliderChanged()
    {
    }


    private static void SlalomDisturbancesToggleChanged()
    {
    }


    private static void SlalomDisturbancesSliderChanged()
    {
    }


    private static void LineKeepingActivateToggleChanged()
    {
    }


    private static void LineKeepingDisturbancesToggleChanged()
    {
    }


    private static void LineKeepingDisturbancesSliderChanged()
    {
    }


    private static void ReactionTestActivateToggleChanged()
    {
    }


    private static void SpeedControlActivateToggleChanged()
    {
    }


    private static void SpeedControlActivateSliderChanged()
    {
    }


    private static void SteeringWheelFeedbackSliderChanged()
    {
    }


    private static void SteeringWheelSensitivitySliderChanged()
    {
    }


    private static void PlatformFeedbackSliderChanged()
    {
    }


    private static void ParaplegiaSupportToggleChanged()
    {
    }
    

    private void ApplySettings()
    {
    }

    public void SaveSettings()
    {
    }

    public void LoadSettings()
    {
    }
}