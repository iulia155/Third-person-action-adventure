using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level002 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectLevel.redirectToLevel = 2;
        RedirectLevel.nextLevel = 4;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
