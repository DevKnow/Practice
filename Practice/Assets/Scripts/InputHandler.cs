using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public ICommand buttonSpace;

    void Start()
    {
        buttonSpace = new JumpCommand();
    }

    void Update()
    {
        InputHandle();
    }

    public ICommand InputHandle()
    {
        if (Input.GetKeyDown(KeyCode.Space)) return buttonSpace;
        else return null;
    }
}
