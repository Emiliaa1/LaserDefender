using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatScene : MonoBehaviour
{
    int whatScene = 1;
    public void GetScene(int x)
    {
        whatScene = x;
    }
    public int ReturnScene()
    {
        return whatScene;
    }

}
