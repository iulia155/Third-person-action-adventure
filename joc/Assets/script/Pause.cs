using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseMusic;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                pauseMusic.Play();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                pauseMusic.Pause();
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pauseMusic.Pause();
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
