using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;//ui����禡�w

public class Menu : MonoBehaviour
{
   
    //�w�q�@�ӥ\���ƥs��Startgame
    public void Startgame()
    {
        //���J����
        SceneManager.LoadScene("main");
    }
    //�w�q�@�ӥ\���ƥs��Exitgame
    public void Exitgame()
    {
        //�������{��
        Application.Quit();
    }
   
}
