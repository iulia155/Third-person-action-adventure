using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GemBlue : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;
    void OnTriggerEnter()
    {
        Score.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
