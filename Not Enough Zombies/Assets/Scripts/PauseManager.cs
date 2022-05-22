using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private Canvas m_PauseMenu;

    private void Start()
    {
        m_PauseMenu = GameObject.Find("PauseMenu").GetComponent<Canvas>();
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
        SceneManager.LoadScene("Settings Menu",LoadSceneMode.Additive);
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
