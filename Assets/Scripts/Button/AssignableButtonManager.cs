using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignableButtonManager : MonoBehaviour
{
  [SerializeField] private Button _throttleButton;
  [SerializeField] private Button _brakeButton;
  [SerializeField] private Button _gearButton;

  private void Awake()
  {
    _throttleButton.onClick.AddListener(() =>
    {

      print("Throttle Button has been pressed");

      //Eventual call to machine param=Machine.callThrottle()
    });

    _brakeButton.onClick.AddListener(() =>
    {
      print("Brake Button has been pressed");

      //Eventual call to machine param=Machine.callBrake()
    });

    _gearButton.onClick.AddListener(() =>
    {
      print("Gear Button has been pressed");

      //Eventual call to machine param=Machine.callGear()
    });

  }

}
