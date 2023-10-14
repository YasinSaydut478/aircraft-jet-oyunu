using UnityEngine;
using System.Collections;

public class PauseMusic : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();
        }
    }
}

