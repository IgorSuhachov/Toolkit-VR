using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float sizeModifier = 2.5f;
    public string newName = "OrangeCube";
    public bool isRotated = false;
    
    void Start()
    {
        transform.name = ImproveName(newName);
        
        if (isRotated)
        {
            transform.localEulerAngles = Vector3.one * 45;
        }
    }

    string ImproveName (string originalString)
    {
        return "-[" + originalString + "]-"; 
    }

    void Update()
    {
        transform.localScale = Vector3.one * sizeModifier;
    }
}
