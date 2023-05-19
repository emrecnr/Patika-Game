using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public void Retry()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void GameOvr()
    {
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }
    
}
