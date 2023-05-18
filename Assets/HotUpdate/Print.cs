using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    public int value = 2;

    void Start()
    {
        Debug.Log($"[Print] GameObject:{name} value:{value}");   
    }
}