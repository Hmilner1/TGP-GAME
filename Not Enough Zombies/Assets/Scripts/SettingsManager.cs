using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    public void OnClickReturn()
    {
        SceneManager.UnloadScene("Settings Menu");
    }
}
