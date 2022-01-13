using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform transform;
    private Rigidbody rigidbody;
    private InputHandler inputHandler;

    void Start()
    {
        transform = GetComponent<Transform>();
        inputHandler = GetComponent<InputHandler>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ICommand command = inputHandler.InputHandle();
        if (command!=null)
        {
            command.execute(this);
        }
    }

    public void jump()
    {
        rigidbody?.AddForce(transform.up * 400.0f);
    }
}
