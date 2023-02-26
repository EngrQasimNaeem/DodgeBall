using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float xRange = 5;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
      
        //left and right movement
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPos = rb.position + Vector2.right * x;

        //Clamps the given value between the given minimum float and maximum float values.
        // Returns the given value if it is within the minimum and maximum range.
        newPos.x = Mathf.Clamp(newPos.x, -xRange, xRange);

        // setting the position/movement of player 
        rb.MovePosition(newPos);
    }

    // void OnCollisionEnter2D()
    // {

    // }
}
