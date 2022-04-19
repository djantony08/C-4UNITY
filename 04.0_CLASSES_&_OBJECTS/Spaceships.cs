using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceships : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shipspecs rocket = new Shipspecs(); // Create 1st Spaceship object
        rocket.color = "BLUE";
        rocket.maxSpeed = 500;

        Debug.Log($"The rocket is painted {rocket.color}");
        Debug.Log($"The Rocket Max Speed is {rocket.maxSpeed}");
        rocket.WarpSpeed("very fast");

        Shipspecs deathStar = new Shipspecs();//Create 2nd Spaceship object
        deathStar.color = "BLACK";
        deathStar.maxSpeed = 1000;

        Debug.Log($"The rocket is painted {deathStar.color}");
        Debug.Log($"The Rocket Max Speed is {deathStar.maxSpeed}");
        deathStar.WarpSpeed("extremely fast");
    }

    // Update is called once per frame
    void Update()
    {
        //ditto
    }

    public class Shipspecs //Class
    {
        public string color; //Spaceship's color
        public int maxSpeed; //Spaceship's Top Speed

        public void WarpSpeed(string txt) //method
        {        
            Debug.Log($"This Spaceship is going {txt} !!");
        }
    }
}
