using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("1st event - I am awake !");
    }

    // Use this for initialization
    void Start ()
    {
        Debug.Log("2nd Event - I have just started once !");
    }

   // Update is called once per frame
    void Update ()
    {
        Debug.Log("3rd Event - I am updating every frame !");
    }
}
