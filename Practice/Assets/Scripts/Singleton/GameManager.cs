using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        InitGame();
    }

    // Start is called before the first frame update
    void InitGame()
    {
        DoHello();
    }

    // Update is called once per frame
    void DoHello()
    {
        Debug.Log("Hello");
    }
}
