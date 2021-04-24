using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    Player player = new Player();
    Rigidbody2D rb;
    public Vector3 direction;
    float speed = 100f;
    float horizontalSpeed = 50f;
    //ScreenLimit screenLimit;;
    public bool touchGround = false;

    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
    }

    public void Accelerate()
    {
        if (Input.GetKey(KeyCode.P))
        {
           
        }
        if (Input.GetKey(KeyCode.W))
        {
            
        }
    }

    public void Proposed1()
    {
      

        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");
        float yForce = v * speed * Time.deltaTime; 
        Vector2 force = new Vector2(0,yForce); 
        rb.AddForce(force);

        float yforce = h * horizontalSpeed * Time.deltaTime;
        Vector2 forceY = new Vector2(yforce, 0);
        rb.AddForce(forceY);

        if (touchGround)
        {
            speed = 0f;
        }
    }

    public void Proposed2()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchGround = false;
        }
    }


    public void Update()
    {
       
    }

    public void FixedUpdate()
    {
        //fisica e comportamenti fisici
        // Accelerate();
        Proposed1();
        //Proposed2();

        //rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxVelocity);

        if (touchGround)
        {
          
        }
    }



}
