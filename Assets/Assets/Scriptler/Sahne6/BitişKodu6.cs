using UnityEngine;
using UnityEngine.UI;

public class BitişKodu6 : MonoBehaviour
{
    Sahne6 script;
    public Text scoreText;
    public Text timeText;




    private void FixedUpdate()
    {
        scoreText.text = script + "Score: " + PlayerPrefs.GetInt("Score").ToString();
        timeText.text = "Time: " + PlayerPrefs.GetFloat("Time").ToString();

    }
}
