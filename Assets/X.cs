using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{
    System.Random rand = new System.Random();
    void Update()
    {
        Screen.SetResolution((int)rand.Next(100,1000), (int)rand.Next(100,1000), false);
    }
}
