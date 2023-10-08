using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;
using UnityEngine.SceneManagement;


public class MenüController : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenü;
    public GameObject optionMenü;
    public GameObject panel;
    public AudioSource there;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            
            
        }
    }
   
    

    public void Resume()
    {
        pauseMenü.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenü.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void çıkış()
    {
        SceneManager.LoadScene(13);
    }
    public void ayarlar()
    {
        pauseMenü.SetActive(false);
        optionMenü.SetActive(true);
        gameIsPaused = true;
    }
    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void setfullscreen(bool isFuul)
    {
        Screen.fullScreen = isFuul;
    }
    public void SetMusic(bool isMusic)
    {
        there.mute = !isMusic;
    }


}
