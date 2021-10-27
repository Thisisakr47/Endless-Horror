using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public static float leftboundary =  -12f;
    public static float rightboundary = 12f;
    public float ileft;
    public float iright;

    void Update()
    {
        ileft = leftboundary;
        iright = rightboundary;
    }
}
