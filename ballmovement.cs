using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //variable for speed
    public float xSpeed = 0; //variable for x movement
    public float ySpeed = 0; // Variable for y speed

    //variable for borders
    private float xBorder = 7.5f; //variable for horizontal border
    private float yBorder = 4.5f; //variavle for verticle border


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; //declare value for horizontal speed
        ySpeed = 0.0125f; //declare value for verticle speed
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement 
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right

        if (transform.position.x >= xBorder)
        {
            xSpeed = -xSpeed; //make it go left
        }

        if(transform.position.x <= -xBorder)
        {
            xSpeed *= -1;
        }

        //verticle movement 
        transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        if (transform.position.y >= yBorder)
        {
            ySpeed *= -1;
        }
        if (transform.position.y <= -yBorder)
        {
            ySpeed *= -1;
        }

    }
}
