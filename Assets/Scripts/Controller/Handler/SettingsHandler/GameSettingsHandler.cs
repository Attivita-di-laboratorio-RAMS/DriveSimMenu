using UnityEngine;
using UnityEngine.UI;

namespace Controller.Handler.SettingsHandler
{
    /// <summary>
    /// Singleton class responsible for managing Game Settings Panel.
    /// </summary>
    public class GameSettingsHandler : MonoBehaviour
    {
        // SINGLETON:
        private static GameSettingsHandler _instance;
        public static GameSettingsHandler Instance => _instance;

        // SERIALIZE FIELDS:
        [Header("Game Settings Panel:")]
        [SerializeField] private GameObject gameSettingsPanel;
        
        [Header("Slalom Settings:")]
        [SerializeField] private Toggle slalomActivateToggle;
        [SerializeField] private Slider slalomActivateSlider;
        [SerializeField] private Toggle slalomDisturbancesToggle;
        [SerializeField] private Slider slalomDisturbancesSlider;

        [Header("Line Keeping Settings:")]
        [SerializeField] private Toggle lineKeepingActivateToggle;
        [SerializeField] private Toggle lineKeepingDisturbancesToggle;
        [SerializeField] private Slider lineKeepingDisturbancesSlider;

        [Header("Reaction Test Settings:")]
        [SerializeField] private Toggle reactionTestActivateToggle;

        [Header("Speed Control Settings:")]
        [SerializeField] private Toggle speedControlActivateToggle;
        [SerializeField] private Slider speedControlActivateSlider;


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
            if (DataManager.SettingsDataInstance.SlalomActivateToggleValue)
            {
                DataManager.SettingsDataInstance.SlalomActivateSliderValue = slalomActivateSlider.value;
            }
            else
            {
                DataManager.SettingsDataInstance.SlalomActivateSliderValue = 0;
            }
            
        }


        private void SlalomDisturbancesToggleChanged()
        {
            if (DataManager.SettingsDataInstance.SlalomActivateToggleValue)
            {
                DataManager.SettingsDataInstance.SlalomDisturbancesToggleValue = slalomDisturbancesToggle.isOn;
            }
            else
            {
                DataManager.SettingsDataInstance.SlalomDisturbancesToggleValue = false;
            }
            
        }


        private void SlalomDisturbancesSliderChanged()
        {
            if (DataManager.SettingsDataInstance.SlalomActivateToggleValue && DataManager.SettingsDataInstance.SlalomDisturbancesToggleValue)
            {
                DataManager.SettingsDataInstance.SlalomDisturbancesSliderValue = slalomDisturbancesSlider.value;
            }
            else
            {
                DataManager.SettingsDataInstance.SlalomDisturbancesSliderValue = 0;
            }
        }


        private void LineKeepingActivateToggleChanged()
        {
            DataManager.SettingsDataInstance.LineKeepingActivateToggleValue = lineKeepingActivateToggle.isOn;
        }


        private void LineKeepingDisturbancesToggleChanged()
        {
            if (DataManager.SettingsDataInstance.LineKeepingActivateToggleValue)
            {
                DataManager.SettingsDataInstance.LineKeepingDisturbancesToggleValue = lineKeepingDisturbancesToggle.isOn;
            }
            else
            {
                DataManager.SettingsDataInstance.LineKeepingDisturbancesToggleValue = false;
            }
        }


        private void LineKeepingDisturbancesSliderChanged()
        {
            if (DataManager.SettingsDataInstance.LineKeepingActivateToggleValue && DataManager.SettingsDataInstance.LineKeepingDisturbancesToggleValue)
            {
                DataManager.SettingsDataInstance.LineKeepingDisturbancesSliderValue = lineKeepingDisturbancesSlider.value;
            }
            else
            {
                DataManager.SettingsDataInstance.LineKeepingDisturbancesSliderValue = 0;
            }
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
            if (DataManager.SettingsDataInstance.SpeedControlActivateToggleValue)
            {
                DataManager.SettingsDataInstance.SpeedControlActivateSliderValue = speedControlActivateSlider.value;
            }
            else
            {
                DataManager.SettingsDataInstance.SpeedControlActivateSliderValue = 0;
            }
        }

        public void Disable()
        {
            slalomActivateToggle.interactable = false;
            slalomActivateSlider.interactable = false;
            slalomDisturbancesToggle.interactable = false;
            slalomDisturbancesSlider.interactable = false;
            lineKeepingActivateToggle.interactable = false;
            lineKeepingDisturbancesToggle.interactable = false;
            lineKeepingDisturbancesSlider.interactable = false;
            reactionTestActivateToggle.interactable = false;
            speedControlActivateToggle.interactable = false;
            speedControlActivateSlider.interactable = false;
        }
        
        public void Enable()
        {
            slalomActivateToggle.interactable = true;
            slalomActivateSlider.interactable = true;
            slalomDisturbancesToggle.interactable = true;
            slalomDisturbancesSlider.interactable = true;
            lineKeepingActivateToggle.interactable = true;
            lineKeepingDisturbancesToggle.interactable = true;
            lineKeepingDisturbancesSlider.interactable = true;
            reactionTestActivateToggle.interactable = true;
            speedControlActivateToggle.interactable = true;
            speedControlActivateSlider.interactable = true;
        }

        public void GetAll()   // TODO: metodo getAll e uno SetAll (in modo da avere direzionalità nell'update: tipo SettingsData>GUI o GUI>SettingsData)
        {
            SlalomActivateToggleChanged();
            SlalomActivateSliderChanged();
            SlalomDisturbancesToggleChanged();
            SlalomDisturbancesSliderChanged();
            LineKeepingActivateToggleChanged();
            LineKeepingDisturbancesToggleChanged();
            LineKeepingDisturbancesSliderChanged(); 
            ReactionTestActivateToggleChanged();
            SpeedControlActivateToggleChanged();
            SpeedControlActivateSliderChanged();
        }

        public void SetAll()
        {
            slalomActivateToggle.isOn = DataManager.SettingsDataInstance.SlalomActivateToggleValue;
            slalomActivateSlider.value = DataManager.SettingsDataInstance.SlalomActivateSliderValue;
            slalomDisturbancesToggle.isOn = DataManager.SettingsDataInstance.SlalomDisturbancesToggleValue;
            slalomDisturbancesSlider.value = DataManager.SettingsDataInstance.SlalomDisturbancesSliderValue;
            lineKeepingActivateToggle.isOn = DataManager.SettingsDataInstance.LineKeepingActivateToggleValue;
            lineKeepingDisturbancesToggle.isOn = DataManager.SettingsDataInstance.LineKeepingDisturbancesToggleValue;
            lineKeepingDisturbancesSlider.value = DataManager.SettingsDataInstance.LineKeepingDisturbancesSliderValue;
            reactionTestActivateToggle.isOn = DataManager.SettingsDataInstance.ReactionTestActivateToggleValue;
            speedControlActivateToggle.isOn = DataManager.SettingsDataInstance.SpeedControlActivateToggleValue;
            speedControlActivateSlider.value = DataManager.SettingsDataInstance.SpeedControlActivateSliderValue;
        }
    
    }
}