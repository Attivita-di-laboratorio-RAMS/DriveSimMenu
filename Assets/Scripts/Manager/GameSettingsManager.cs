using UnityEngine;
using UnityEngine.UI;

namespace Manager
{
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
        [SerializeField] private Toggle slalomDisturbancesToggle;
        [SerializeField] private Slider slalomDisturbancesSlider;

        [Header("Line Keeping Settings:")] [SerializeField]
        private Toggle lineKeepingActivateToggle;

        [SerializeField] private Toggle lineKeepingDisturbancesToggle;
        [SerializeField] private Slider lineKeepingDisturbancesSlider;

        [Header("Reaction Test Settings:")] [SerializeField]
        private Toggle reactionTestActivateToggle;

        [Header("Speed Control Settings:")] [SerializeField]
        private Toggle speedControlActivateToggle;

        [SerializeField] private Slider speedControlActivateSlider;


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
            DataManager.SettingsDataInstance.SlalomActivateToggleValue = slalomActivateToggle.isOn;
        }


        private void SlalomActivateSliderChanged()
        {
            DataManager.SettingsDataInstance.SlalomActivateSliderValue = slalomActivateSlider.value;
        }


        private void SlalomDisturbancesToggleChanged()
        {
            DataManager.SettingsDataInstance.SlalomDisturbancesToggleValue = slalomDisturbancesToggle.isOn;
        }


        private void SlalomDisturbancesSliderChanged()
        {
            DataManager.SettingsDataInstance.SlalomActivateSliderValue = slalomActivateSlider.value;
        }


        private void LineKeepingActivateToggleChanged()
        {
            DataManager.SettingsDataInstance.LineKeepingActivateToggleValue = lineKeepingActivateToggle.isOn;
        }


        private void LineKeepingDisturbancesToggleChanged()
        {
            DataManager.SettingsDataInstance.LineKeepingDisturbancesToggleValue = lineKeepingDisturbancesToggle.isOn;
        }


        private void LineKeepingDisturbancesSliderChanged()
        {
            DataManager.SettingsDataInstance.LineKeepingDisturbancesSliderValue = lineKeepingDisturbancesSlider.value;
        }


        private void ReactionTestActivateToggleChanged()
        {
            DataManager.SettingsDataInstance.ReactionTestActivateToggleValue = reactionTestActivateToggle.isOn;
        }


        private void SpeedControlActivateToggleChanged()
        {
            DataManager.SettingsDataInstance.SpeedControlActivateToggleValue = speedControlActivateToggle.isOn;
        }


        private void SpeedControlActivateSliderChanged()
        {
            DataManager.SettingsDataInstance.SpeedControlActivateSliderValue = speedControlActivateSlider.value;
        }
    
    }
}