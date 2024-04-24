using UnityEngine;
using UnityEngine.UI;

namespace View
{
    /// <summary>
    /// Singleton class responsible for managing DriveSim Feedback Panel.
    /// </summary>
    public class DriveSimFeedbackPanel : MonoBehaviour
    {
        // SINGLETON:
        private static DriveSimFeedbackPanel _instance;

        // SERIALIZE FIELDS:
        [Header("Steering Wheel:")]
        [SerializeField] private Transform steeringWheelObject;
    
        [Header("Pedals:")]
        [SerializeField] private Slider clutchSlider;
        [SerializeField] private Slider brakeSlider;
        [SerializeField] private Slider throttleSlider;
    
    
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


        void Update()
        {
            // IMPORTANT NOTES: time expensive functions like Map() or checking if a reference!=null must be placed outside of Update()!!!
            //float value = Map(floatInput, minInput, maxInput, minOutput, maxOutput);  
        
            /*  REMOVE COMMENT
            float value = GameManager.wheelManager.physicalPos;
            steeringWheelObject.rotation = Quaternion.Euler(0, 0, value);

            value = GameManager.wheelManager.clutch;
            clutchSlider.value = value;
        
            value = GameManager.wheelManager.brake;
            brakeSlider.value = value;
        
            value = GameManager.wheelManager.throttle;
            throttleSlider.value = value;
            */
        }
    }
}
