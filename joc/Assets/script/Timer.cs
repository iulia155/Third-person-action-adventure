using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject time1;
    public GameObject time2;
    public bool isTakingTime = false;
    public int seconds = 150;
    public static int extendScore;

    // Update is called once per frame
    void Update()
    {
        extendScore = seconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }
    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        seconds -= 1;
        time1.GetComponent<Text>().text = "" + seconds;
        time2.GetComponent<Text>().text = "" + seconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
