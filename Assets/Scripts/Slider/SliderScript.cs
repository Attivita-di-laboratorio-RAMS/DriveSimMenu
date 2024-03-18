using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
  [SerializeField] private Slider _slider;
  [SerializeField] private TextMeshProUGUI _sliderText;
  [SerializeField] private string _placeholder;

  private void Awake()
  {
    _slider.onValueChanged.AddListener((v) =>
    {
      _sliderText.text = v.ToString("0");
      _sliderText.text= string.Concat(_sliderText.text, " " + _placeholder);
    });
  }
}

