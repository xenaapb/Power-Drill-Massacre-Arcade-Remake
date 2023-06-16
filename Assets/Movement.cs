using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    Rigidbody2D rigidbody;

    SpriteRenderer spriteRenderer;



    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();


    }    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));

        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, -speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

        }*/

    }
}
