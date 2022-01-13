using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeActor : Observer
{
    GameObject _cube;

    // Use this for initialization
    public override void OnNotify()
    {
        _cube = GameObject.Find("Cube") as GameObject;
        DoMove();
    }

    void DoMove()
    {
        _cube.transform.position = new Vector3(3f, 3f, 3f);
    }
}
