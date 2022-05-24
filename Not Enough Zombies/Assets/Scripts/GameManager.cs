using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerHealth.PlayerDead += GameOver;
    }
    private void OnDisable()
    {
        PlayerHealth.PlayerDead -= GameOver;
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        Debug.Log("GameOver");
    }

}
