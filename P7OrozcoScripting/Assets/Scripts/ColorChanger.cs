using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }if(Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }if(Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }if(Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }if(Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }if(Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }if(Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.blue, 0.5f);
        }if(Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.yellow, 0.5f);
        }if(Input.GetKeyDown(KeyCode.T))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.cyan, Color.magenta, 0.5f);
        }if(Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.black, 0.5f);
        }if(Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.green, 0.5f);
        }if(Input.GetKeyDown(KeyCode.J))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.blue, Color.yellow, 0.5f);
        }if(Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.cyan, Color.magenta, 0.5f);
        }if(Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.black, 0.5f);
        }if(Input.GetKeyDown(KeyCode.V))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.blue, 0.5f);
        }if(Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.yellow, 0.5f);
        }if(Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.cyan, Color.magenta, 0.5f);
        }if(Input.GetKeyDown(KeyCode.Comma))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.black, 0.5f);
        }if(Input.GetKeyDown(KeyCode.Period))
        {
            GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.green, 0.5f);
        }
    }
}
