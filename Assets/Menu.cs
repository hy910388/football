using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;//ui物件函式庫

public class Menu : MonoBehaviour
{
   
    //定義一個功能函數叫做Startgame
    public void Startgame()
    {
        //載入場景
        SceneManager.LoadScene("main");
    }
    //定義一個功能函數叫做Exitgame
    public void Exitgame()
    {
        //關閉此程式
        Application.Quit();
    }
   
}
