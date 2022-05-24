using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private Canvas m_PauseMenu;
    private Canvas m_SettingsMenu;

    private void Start()
    {
        m_PauseMenu = GameObject.Find("PauseMenu").GetComponent<Canvas>();
        m_SettingsMenu = GameObject.Find("SettingsMenu").GetComponent<Canvas>();
        m_SettingsMenu.enabled = false;
        m_PauseMenu.enabled = false;
    }

    private void OnEnable() => InputManager.OnPause += OnPauseMenu;
    private void OnDisable() => InputManager.OnPause -= OnPauseMenu;
    private void OnPauseMenu()
    {
        Debug.Log("Pause");
        if (m_PauseMenu.enabled)
        {
            m_PauseMenu.enabled = false;
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            m_SettingsMenu.enabled = false;
        }
        else if (!m_PauseMenu.enabled)
        {
            m_PauseMenu.enabled = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void OnClickSettingsMenu()
    {
        //SceneManager.LoadScene("Settings Menu",LoadSceneMode.Additive);
        if (m_SettingsMenu.enabled == false)
        {
            m_SettingsMenu.enabled = true;
        }
        else if (m_SettingsMenu.enabled == true)
        {
            m_SettingsMenu.enabled = false;
        }
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickResume()
    {
        OnPauseMenu();
    }
}
