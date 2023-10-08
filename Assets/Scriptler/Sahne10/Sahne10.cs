using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Sahne10 : MonoBehaviour
{
    public Timer10 timerScript;
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
            // son engelde bunu devreye girmesini istiyorum bunu nas�l yapabilirim
            // �uanda e�er son engelde bu tag varsa girecek
            score++;
            scoreText.text = "Score: " + score;

            if (score < hedefScore)
            {
                Debug.Log("KAYBETT�");
                Kaybetme();
            }
            else
            {
                Debug.Log("KAZANDI");
                Kazanma();
                SceneManager.LoadScene(30);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Engele �arp�nca
        //bunu buraya ald�m ��nk� kaybedince skoru ve zaman� da g�steriyoruz,
        //e�er d���ce kaybedeceksek kaydetmemiz laz�m o y�zden onu buraya ta��d�m
        if (!collision.gameObject.CompareTag("Engel") || !collision.gameObject.CompareTag("Son Engel"))
        {
            Kaybetme();
        }
    }



    private void Kazanma()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("Time", Mathf.Round(60 - timerScript.time));
        SceneManager.LoadScene(30);
    }

    private void Kaybetme()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("Time", Mathf.Round(60 - timerScript.time));
        SceneManager.LoadScene(31);

    }
}
