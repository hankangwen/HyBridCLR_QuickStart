using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello
{
    public static void Run()
    {
        Debug.Log("Hello, World");
        
        GameObject go = new GameObject("Test1");
        go.AddComponent<Print>();
    }
}
