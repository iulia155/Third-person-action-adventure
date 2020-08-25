using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;


    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
        
    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        Score.currentScore = 0;
        Finish.totalScored = 0;
        SceneManager.LoadScene(RedirectLevel.redirectToLevel);
    }
}
