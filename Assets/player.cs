using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class player : MonoBehaviour
{
    private Rigidbody Ball;
    public float mymove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ball= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Ball.linearVelocity = new Vector3(mymove, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Ball.linearVelocity = new Vector3(-mymove, 0, 0);
        }
       
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            Ball.linearVelocity = new Vector3(0, 0, 0);
        }

        
        if (Input.GetKeyUp(KeyCode.Space))
        {
             Ball.linearVelocity= new Vector3(0, mymove, 10*mymove);
           // Ball.AddForce(0, 10, 100);
            
            //Instantiate(kickeffect, Ball.transform.position, Quaternion.identity);
           
            // kickeffect.Play();
        }
    }
}
