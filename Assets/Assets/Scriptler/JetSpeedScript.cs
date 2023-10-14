using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JetSpeedScript : MonoBehaviour
{

    public Rigidbody jetRigidbody;


    public Text speedText;

    // Start metodu
    void Start()
    {

        jetRigidbody = GetComponent<Rigidbody>();

        speedText = GameObject.Find("SpeedText").GetComponent<Text>();
    }


    void Update()
    {

        float speed = jetRigidbody.velocity.magnitude;
        speed = Mathf.Round(speed);
        speedText.text = "Speed: " + speed + " m/s";
        

    }
}
