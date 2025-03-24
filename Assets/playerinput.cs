using UnityEngine;
using UnityEngine.InputSystem;

public class playerinput : MonoBehaviour
{
    private Rigidbody Ball;
    public float mymove;
    private float moveInput;
    
    private AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(moveInput, 0, 0) * mymove * Time.deltaTime;
        transform.position += move;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<float>();
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Ball.AddForce(Vector3.forward * mymove, ForceMode.Impulse);
            audio.Play();
        }
    }

    }

