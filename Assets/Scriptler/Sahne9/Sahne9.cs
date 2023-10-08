using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Sahne9 : MonoBehaviour
{
    public Timer9 timerScript;
    public int score = 0;
    public GameObject text;
    public float hedefScore;
    public Text scoreText;


    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "Score: " + score;
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Engel"))
        {
            score++;
            scoreText.text = "Score: " + score;
        }
        if (other.CompareTag("Son Engel"))
        {
            // son engelde bunu devreye girmesini istiyorum bunu nasýl yapabilirim
            // þuanda eðer son engelde bu tag varsa girecek
            score++;
            scoreText.text = "Score: " + score;

            if (score < hedefScore)
            {
                Debug.Log("KAYBETTÝ");
                Kaybetme();
            }
            else
            {
                Debug.Log("KAZANDI");
                Kazanma();
                SceneManager.LoadScene(29);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Engele çarpýnca
        //bunu buraya aldým çünkü kaybedince skoru ve zamaný da gösteriyoruz,
        //eðer düþüce kaybedeceksek kaydetmemiz lazým o yüzden onu buraya taþýdým
        if (!collision.gameObject.CompareTag("Engel") || !collision.gameObject.CompareTag("Son Engel"))
        {
            Kaybetme();
        }
    }



    private void Kazanma()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("Time", Mathf.Round(60 - timerScript.time));
        SceneManager.LoadScene(29);
    }

    private void Kaybetme()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("Time", Mathf.Round(60 - timerScript.time));
        SceneManager.LoadScene(28);

    }
}
