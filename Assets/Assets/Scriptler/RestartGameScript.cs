using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGameScript : MonoBehaviour
{

    public void sahne1()
    {
        SceneManager.LoadScene(4);
    }
    public void sahne2()
    {
        SceneManager.LoadScene(5);
    }
    public void sahne3()
    {
        SceneManager.LoadScene(6);
    }
    public void sahne4()
    {
        SceneManager.LoadScene(7);
    }
    public void sahne5()
    {
        SceneManager.LoadScene(8);
    }
    public void sahne6()
    {
        SceneManager.LoadScene(9);
    }
    public void sahne7()
    {
        SceneManager.LoadScene(10);
    }
    public void sahne8()
    {
        SceneManager.LoadScene(11);
    }
    public void sahne9()
    {
        SceneManager.LoadScene(12);
    }
    public void sahne10()
    {
        SceneManager.LoadScene(3);
    }
    public void menü()
    {
        SceneManager.LoadScene(13);
    }
    public void çýkýþ()
    {
        Application.Quit();
        print("Oyundan Çýkýldý");
    }
    public void kontroller()
    {
        SceneManager.LoadScene(32);
    }
    public void Geri()
    {
        SceneManager.LoadScene(0);
    }
    public void AyarlarMenüsü()
    {
        SceneManager.LoadScene(33);
    }
}


