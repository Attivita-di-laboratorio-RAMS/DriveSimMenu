using Controller.Handler.SettingsHandler;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Controller.Handler.StatusHandler
{
    /// <summary>
    /// Singleton class responsible for managing Status/Button Panel.
    /// </summary>
    public class StatusButtonHandler : MonoBehaviour
    {
        // SINGLETON:
        private static StatusButtonHandler _instance;
        public static StatusButtonHandler Instance => _instance;

        
        // SERIALIZE FIELDS:
        [Header("Buttons:")]
        [SerializeField] private Button playButton;
        [SerializeField] private Button stopButton;
        [SerializeField] private Button homeButton;
    
        [Header("Status:")]
        [SerializeField] private TextMeshProUGUI statusText;
        [SerializeField] private Image statusLed;


    
        // VARIABLES:
        private StatusEnum _currentStatus;
        private StatusEnum _oldStatus = StatusEnum.Stopped;
        private bool _isConnected = false;
    
    
        // ACCESSORS:
        public StatusEnum CurrentSystemStatus
        {
            get => _currentStatus;
            set => _currentStatus = value;
        }
        
    
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
            playButton.onClick.AddListener(delegate { PlayButtonClicked(); });
            stopButton.onClick.AddListener(delegate { StopButtonClicked(); });
            homeButton.onClick.AddListener(delegate { HomeButtonClicked(); });
            _currentStatus = StatusEnum.Initializing;
        }


        private void Update()
        {
            UpdateStatus();
        }


        // METHODS:
        private void PlayButtonClicked()
        {
            if (_currentStatus == StatusEnum.Running)
            {
                _currentStatus = StatusEnum.Pausing;
            }
            else
            {
                _currentStatus = StatusEnum.Starting;
            }
        }


        private void StopButtonClicked()
        {
            _currentStatus = StatusEnum.Stopping;
        }


        private void HomeButtonClicked()
        {
            _currentStatus = StatusEnum.Homing;
        }


        private void UpdateStatus()
        {
            if (_isConnected)
            {
                statusLed.color = Color.green;  // TODO: add custom color enum to match the system color palette
            }
            else statusLed.color = Color.red;
            
            if (_oldStatus != _currentStatus)      // check if status has changed
            {
                _oldStatus = _currentStatus;
                
                switch (_currentStatus)
                {
                    case StatusEnum.Initializing:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "INITIALIZING";
                        statusText.color = Color.blue;
                        _currentStatus = StatusEnum.Ready;
                        break;

                    case StatusEnum.Homing:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "HOMING";
                        statusText.color = Color.blue;
                        _currentStatus = StatusEnum.Ready;
                        break;

                    case StatusEnum.Ready:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "READY";
                        statusText.color = Color.green;
                        break;

                    case StatusEnum.Starting:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "STARTING";
                        statusText.color = Color.green;
                        _currentStatus = StatusEnum.Running;
                        break;

                    case StatusEnum.Running:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/pause");
                        statusText.text = "RUNNING";
                        statusText.color = Color.green;
                        break;

                    case StatusEnum.Pausing:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "PAUSING";
                        statusText.color = Color.yellow;
                        _currentStatus = StatusEnum.Paused;
                        break;

                    case StatusEnum.Paused:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "PAUSED";
                        statusText.color = Color.yellow;
                        break;

                    case StatusEnum.Stopping:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "STOPPING";
                        statusText.color = Color.red;
                        _currentStatus = StatusEnum.Stopped;
                        break;

                    case StatusEnum.Stopped:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "STOPPED";
                        statusText.color = Color.red;
                        break;

                    case StatusEnum.Error:
                        ((Image)playButton.targetGraphic).sprite = Resources.Load<Sprite>("Sprites/Button/play");
                        statusText.text = "ERROR";
                        statusText.color = Color.red;
                        break;
                }
                
                /*
                if (_currentStatus == StatusEnum.Ready || _currentStatus == StatusEnum.Paused ||
                    _currentStatus == StatusEnum.Stopped)
                {
                    GameSettingsHandler.Instance.Enable();
                    SystemSettingsHandler.Instance.Enable();
                }
                else
                {
                    GameSettingsHandler.Instance.Disable();
                    SystemSettingsHandler.Instance.Disable();
                }
                */
                
            }
            
        }
        
    }
}