using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Timer10 : MonoBehaviour
{
    public float time = 60f;
    public Sahne10 script;
    public Text timeText;
    internal object velocity;

    // Start metodu
    void Start()
    {
        timeText = GameObject.Find("TimeText").GetComponent<Text>();

        timeText.text = "Time: " + time;
    }

    void Update()
    {
        time -= Time.deltaTime;
        //
        timeText.text = "Time: " + Mathf.Round(time);

        if (time <= 0)
        {
            Debug.Log("Game Over");
            PlayerPrefs.SetInt("Score", script.score);
            PlayerPrefs.SetFloat("Time", Mathf.Round(60 - time));
            SceneManager.LoadScene(31);
        }
    }
}
