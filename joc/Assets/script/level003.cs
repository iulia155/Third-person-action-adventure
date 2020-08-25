using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level003 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectLevel.redirectToLevel = 2;
        RedirectLevel.nextLevel = 5;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
