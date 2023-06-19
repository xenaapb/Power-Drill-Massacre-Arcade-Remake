using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject square ;
    // Start is called before the first frame update
    Rigidbody2D rigidbody;

    SpriteRenderer spriteRenderer;

   



    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        square.SetActive(true);



    }    
    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(Input.GetAxis("Horizontal"));

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

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag =="Darkness")
        {
           Debug.Log("you did it");
           other.gameObject.SetActive(false);
            
        }
        


    }


}
