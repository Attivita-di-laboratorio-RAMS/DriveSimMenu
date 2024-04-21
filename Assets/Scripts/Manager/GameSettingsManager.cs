using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Singleton class responsible for managing Game Settings Panel.
/// </summary>
public class GameSettingsManager : MonoBehaviour
{
    // SINGLETON:
    private static GameSettingsManager _instance;

    // SERIALIZE FIELDS:
    [Header("Slalom Settings:")] [SerializeField]
    private Toggle slalomActivateToggle;

    [SerializeField] private Slider slalomActivateSlider;
    [SerializeField] private TextMeshProUGUI slalomActivateSliderText;
    [SerializeField] private Toggle slalomDisturbancesToggle;
    [SerializeField] private Slider slalomDisturbancesSlider;
    [SerializeField] private TextMeshProUGUI slalomDisturbancesSliderText;

    [Header("Line Keeping Settings:")] [SerializeField]
    private Toggle lineKeepingActivateToggle;

    [SerializeField] private Toggle lineKeepingDisturbancesToggle;
    [SerializeField] private Slider lineKeepingDisturbancesSlider;
    [SerializeField] private TextMeshProUGUI lineKeepingDisturbancesSliderText;

    [Header("Reaction Test Settings:")] [SerializeField]
    private Toggle reactionTestActivateToggle;

    [Header("Speed Controll Settings:")] [SerializeField]
    private Toggle speedControlActivateToggle;

    [SerializeField] private Slider speedControlActivateSlider;
    [SerializeField] private TextMeshProUGUI speedControlActivateSliderText;



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
    }


    // METHODS:
    private void SlalomActivateToggleChanged()
    {
        GameManager.slalomActive = slalomActivateToggle.isOn;
    }


    private void SlalomActivateSliderChanged()
    {
        GameManager.ConesDistance = slalomActivateSlider.value;
    }


    private void SlalomDisturbancesToggleChanged()
    {
        GameManager.slalomDisturbanceActive = slalomDisturbancesToggle.isOn;
    }


    private void SlalomDisturbancesSliderChanged()
    {
        GameManager.slalomDisturbanceModule = slalomDisturbancesSlider.value;
    }


    private void LineKeepingActivateToggleChanged()
    {
        GameManager.lineKeepingActive = lineKeepingActivateToggle.isOn;
    }


    private void LineKeepingDisturbancesToggleChanged()
    {
        GameManager.lineKeepingDisturbanceActive = lineKeepingDisturbancesToggle.isOn;
    }


    private void LineKeepingDisturbancesSliderChanged()
    {
        GameManager.lineKeepingDisturbanceModule = lineKeepingDisturbancesSlider.value;
    }


    private void ReactionTestActivateToggleChanged()
    {
        GameManager.reactionTestActive = reactionTestActivateToggle.isOn;
    }


    private void SpeedControlActivateToggleChanged()
    {
        GameManager.speedControlActive  = speedControlActivateToggle.isOn;
    }


    private void SpeedControlActivateSliderChanged()
    {
        GameManager.speedControlTargetspeed = speedControlActivateSlider.value;
    }
    
}