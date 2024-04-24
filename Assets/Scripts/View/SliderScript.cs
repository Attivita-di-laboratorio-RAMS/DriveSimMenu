using TMPro;
using UnityEngine;

namespace View
{
    public class SliderScript : MonoBehaviour
    {
        [SerializeField] private UnityEngine.UI.Slider slider;
        [SerializeField] private TextMeshProUGUI sliderText;
        [SerializeField] private string placeholder;

        private void Awake()
        {
            slider.onValueChanged.AddListener((v) =>
            {
                sliderText.text = v.ToString("0");
                sliderText.text = string.Concat(sliderText.text, " " + placeholder);
            });
        }
    }
}