using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirme : MonoBehaviour
{
    

    public void seviye1bitirme()
    {
        LevelKilit.seviye2 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye2bitirme()
    {
        LevelKilit.seviye3 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye3bitirme()
    {
        LevelKilit.seviye4 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye4bitirme()
    {
        LevelKilit.seviye5 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye5bitirme()
    {
        LevelKilit.seviye6 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye6bitirme()
    {
        LevelKilit.seviye7 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye7bitirme()
    {
        LevelKilit.seviye8 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye8bitirme()
    {
        LevelKilit.seviye9 = true;
        SceneManager.LoadScene(13);
    }
    public void seviye9bitirme()
    {
        LevelKilit.seviye0 = true;
        SceneManager.LoadScene(13);
    }
    public void bitiþ()
    {
        SceneManager.LoadScene(13);
    }
}
