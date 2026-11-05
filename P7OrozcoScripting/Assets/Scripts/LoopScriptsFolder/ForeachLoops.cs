using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoops : MonoBehaviour
{
    string[] strings = new string[3];
    // Start is called before the first frame update
    void Start()
    {
        strings[0] = "First String";
        strings[1] = "Second String";
        strings[2] = "Third String";

        foreach  (string item in strings)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
