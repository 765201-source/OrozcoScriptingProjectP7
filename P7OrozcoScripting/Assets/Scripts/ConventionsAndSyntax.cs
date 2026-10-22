using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start()
    {
        //this line is there to tell me the x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        //this line is there to tell me the y position of my object
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
        else
        {
            Debug.Log("Yay im safe!");
        }
    }
}