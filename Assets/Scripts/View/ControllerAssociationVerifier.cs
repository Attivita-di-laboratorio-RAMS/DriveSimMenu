using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace View
{
    public class ControllerAssociationVerifier : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        // SERIALIZE FIELDS:
        [SerializeField] private UnityEngine.UI.Button assignThrottleButton;
        [SerializeField] private UnityEngine.UI.Button assignBrakeButton;
        [SerializeField] private UnityEngine.UI.Button assignReverseButton;

        private Image _buttonImage;
        private Color _assignThrottleButtonNormalColor, _assignBrakeButtonNormalColor, _assignReverseButtonNormalColor;
        private readonly Color _assignedColor = Color.green;
        private readonly Color _notAssignedColor = Color.white;
        private UnityEngine.UI.Button _hoveredButton;

        void Start()
        {
            // save normal colors
            _assignThrottleButtonNormalColor = assignThrottleButton.GetComponent<Image>().color;
            _assignBrakeButtonNormalColor = assignBrakeButton.GetComponent<Image>().color;
            _assignReverseButtonNormalColor = assignReverseButton.GetComponent<Image>().color;
        }

        // when mouse enters a button
        public void OnPointerEnter(PointerEventData eventData)
        {
            // get the button where pointer is hovering
            _hoveredButton = eventData.pointerEnter.GetComponentInParent<UnityEngine.UI.Button>();
        
            if (_hoveredButton.gameObject == assignThrottleButton.gameObject)
            {
                if (true)   //CHANGE WITH: GameManager.wheelManager.throttle_Paraplegia
                {
                    assignThrottleButton.GetComponent<Image>().color = _assignedColor;
                }
                else
                {
                    assignThrottleButton.GetComponent<Image>().color = _notAssignedColor;
                }
            }
            else if (_hoveredButton.gameObject == assignBrakeButton.gameObject)
            {
                if (true)   //CHANGE WITH: GameManager.wheelManager.brake_Paraplegia
                {
                    assignBrakeButton.GetComponent<Image>().color = _assignedColor;
                }
                else
                {
                    assignBrakeButton.GetComponent<Image>().color = _notAssignedColor;
                }
            }
            else if (_hoveredButton.gameObject == assignReverseButton.gameObject)
            {
                if (true)   //CHANGE WITH: GameManager.wheelManager.reverse_Paraplegia
                {
                    assignReverseButton.GetComponent<Image>().color = _assignedColor;
                }
                else
                {
                    assignReverseButton.GetComponent<Image>().color = _notAssignedColor;
                }
            }
        }


        // when mouse exits a button
        public void OnPointerExit(PointerEventData eventData)
        {
            assignThrottleButton.GetComponent<Image>().color = _assignThrottleButtonNormalColor;
            assignBrakeButton.GetComponent<Image>().color = _assignBrakeButtonNormalColor;
            assignReverseButton.GetComponent<Image>().color = _assignReverseButtonNormalColor;
        }
    }
}
