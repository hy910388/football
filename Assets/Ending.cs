using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="gate")
        {
            SceneManager.LoadScene("Clear");
        }
        else if(other.gameObject.tag=="Gameover")
        {
            Debug.Log("deathzone");
            SceneManager.LoadScene("Gameover");
        }
    }
}
