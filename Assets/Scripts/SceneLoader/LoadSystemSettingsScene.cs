using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSystemSettingsScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("SystemSettingsMenu");
    }
}