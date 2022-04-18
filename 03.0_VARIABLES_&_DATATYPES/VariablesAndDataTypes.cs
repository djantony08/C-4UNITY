using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndDataTypes: MonoBehaviour
{
    public int num = 1;
    public float speed = 5f;
    public string c = "in the z-axis !";  
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Player = {num} is moving {c} with speed = {speed}");
    }

    // Update is called once per frame
    void Update()
    {
        //Ditto
    }
}
