using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject TheScore;
    public GameObject totalScore;
    public  int timeCalc;
    public  int scoreCalc;
    public static int totalScored;
    public GameObject fadeOut;


    void OnTriggerEnter()
    {
        
        timeCalc = Timer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Time Left : " + Timer.extendScore + " x 100";
        TheScore.GetComponent<Text>().text = "Score : " + Score.currentScore;
        totalScored = Score.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score : " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        TheScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        Score.currentScore = Finish.totalScored;
        SceneManager.LoadScene(RedirectLevel.nextLevel);

    }
}
