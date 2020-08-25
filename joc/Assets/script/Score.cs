using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject score;
    public static int currentScore;
    public int internalScore;

    // Update is called once per frame
    void Update()
    {
        internalScore = currentScore;
        score.GetComponent<Text>().text = "" + internalScore;
    }
}
