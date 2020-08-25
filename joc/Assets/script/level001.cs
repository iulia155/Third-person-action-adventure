using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level001 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        Score.currentScore = 0;
        Finish.totalScored = 0;
        RedirectLevel.redirectToLevel = 2;
        RedirectLevel.nextLevel = 3;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
