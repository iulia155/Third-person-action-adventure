using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public GameObject fadeOut;

    void Start()
    {
        RedirectLevel.nextLevel = 0;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(6);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(RedirectLevel.nextLevel);
    }
}
