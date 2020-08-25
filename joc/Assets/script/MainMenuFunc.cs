using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunc : MonoBehaviour
{
    public AudioSource buttonPress;
    public int lastScore;
    public GameObject lastScoreDisplay;

    void Start()
    {
        lastScore = PlayerPrefs.GetInt("LevelScore");
        lastScoreDisplay.GetComponent<Text>().text = "Last : " + lastScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        RedirectLevel.redirectToLevel = 2;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }
    public void ResetBest()
    {
        buttonPress.Play();
        PlayerPrefs.SetInt("LevelScore", 0);
    }
}
