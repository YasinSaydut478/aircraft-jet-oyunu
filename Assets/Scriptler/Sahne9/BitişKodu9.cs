using UnityEngine;
using UnityEngine.UI;

public class BitişKodu9 : MonoBehaviour
{
    Sahne9 script;
    public Text scoreText;
    public Text timeText;




    private void FixedUpdate()
    {
        scoreText.text = script + "Score: " + PlayerPrefs.GetInt("Score").ToString();
        timeText.text = "Time: " + PlayerPrefs.GetFloat("Time").ToString();

    }
}
