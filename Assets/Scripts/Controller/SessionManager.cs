using UnityEngine;
using UnityEngine.UI;

namespace Controller
{
    /// <summary>
    /// Singleton class responsible for managing the whole Session.
    /// </summary>
    public class SessionManager : MonoBehaviour
    {
        // SINGLETON:
        private static SessionManager _instance;
        public static SessionManager Instance => _instance;
        
        
        // SERIALIZE FIELDS:
        [SerializeField] private Button quitButton;
        
        
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
            
            // AWAKE ALL NON-MONOBEHAVIOUR CLASSES:
            var dataManagerInstance = DataManager.Instance;
            
            // TODO: loadSettings(filename);
        }


        private void Start()
        {
            quitButton.onClick.AddListener(delegate { EndSession(); });
        }
        
        
        // METHODS:
        private void EndSession()
        {
            DataManager.Instance.SaveSettings(DataManager.SettingsDataInstance.Username);
            DataManager.Instance.SaveReport(DataManager.SettingsDataInstance.Username);
        }
        
    }
}