using UnityEngine;
using js.SpacePlatformGame;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : Player //---> farlo derivare direttamente da player 
{
    #region variabili momentanee InputPc

    [Range(0f,50f)][Tooltip("normalmente settato a 10")]
    public float force;
    [Range(0f,20f)] [Tooltip("normalmente settato a 5 // se non funziona il cambio, guardare bene nel metodo ")]
    public float horizontalForce;
    public float maxSpeed;
    public bool touchGround;
    bool canMoving = false;

    //public Player player = new Player(10);

    Rigidbody2D rb;
    Animator Anim;

    public bool left = false;
    public bool right = false;
    public bool accelerationUp;

    #endregion

    #region Test Variablese
    public GameObject flagPizzeria;
    public GameObject firstLimit;
    public GameObject secondLimit;
    public GameObject thirdLimit;
    public float maxVelocity = 10f;
    public float actualSpeedY;
    public float timer = 0;
    public bool startTimer;


    public float maxScreenUp;
    public float maxScreenLeft;
    public float maxScreenRight;

    

    #endregion
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>(); // occhio agli spostamenti dell'oggetto
        //Anim = GetComponentInParent<Animator>();
    }

    #region PcInputs
    public void Thrust()
    {
        float xSpeed = force * Time.deltaTime;
        Vector2 upDirection = new Vector2(0, xSpeed);
        float yspeed = horizontalForce * Time.deltaTime;
        Vector2 horizontalDirection = new Vector2(yspeed, 0);
      

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(upDirection);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(horizontalDirection);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-horizontalDirection);
        }

        
        if (!touchGround)
        {
            horizontalForce = 5f;
        }
        else horizontalForce = 0f;


        Anim.SetFloat("Acceleration", Input.GetAxis("Vertical"));
        // se serve in mobile input mettere in script
        
    }

    // Option 2
    void Thrust2() // meno quotata
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float xSpeed = h * force * Time.deltaTime;
        float ySpeed = v * horizontalForce * Time.deltaTime;
        Vector2 upDirection = new Vector2(xSpeed, 0);
        Vector3 hDirection = new Vector3(0, ySpeed);
        rb.AddForce(hDirection);

        if (!touchGround)
        {
            horizontalForce = 5f;
        }
        else horizontalForce = 0f;

        
    }



    #endregion

    #region Mobile Inputs
   
    public void LeftDirection()
    {
        left = true;
    }
    public void LeftDirectionBrake()
    {
        left = false;
    }
    public void RightDirection()
    {
        right = true;
    }
    public void RightDirectionBrake()
    {
        right = false;
    }
    public void Acceleration()
    {
        accelerationUp = true;
        canMoving = true;

        
    }

    

    public void Brake()
    {
        accelerationUp = false;

        if (accelerationUp == false)
        {
            canMoving = false;
        }
    }

    public void ThrustMobile() //Attualmente usata per il movimento mobile
    {
        float ySpeed = force * Time.deltaTime;
        float xSpeed = horizontalForce * Time.deltaTime;
        Vector2 directionHorizontal = new Vector2(xSpeed, 0);
        Vector2 directionUp = new Vector3(0, ySpeed);
        
        if (accelerationUp)
        {
            rb.AddForce(directionUp);
           
        }

        if (left)
        {
            rb.AddForce(-directionHorizontal);
        }

        if (right)
        {
            rb.AddForce(directionHorizontal);
        }

        //Anim.SetFloat("Acceleration", Input.GetAxis("Vertical"));
        //Anim.SetFloat("Acceleration",directionUp.y);
        //Debug.Log(directionUp);
        Anim.SetBool("CanMoving", canMoving);

    }


    public void TrustOption2()
    {
        // calcolare vettore di potenza

        float ySpeed = force * Time.deltaTime; // velocità
        float xSpeed = horizontalForce * Time.deltaTime; // velocità
        Vector2 directionHorizontal = new Vector2(xSpeed, 0); // vettore di traslazione asse x
        Vector2 directionUp = new Vector3(0, ySpeed);  // vettore di traslazione asse y

        if (accelerationUp)
        {
            rb.AddForce(directionUp);

        }
        
        if (left)
        {
            rb.AddForce(-directionHorizontal);
        }


        if (right)
        {
            rb.AddForce(directionHorizontal);
        }

        Anim.SetFloat("Acceleration", Input.GetAxis("Vertical"));

    }

    #endregion

    #region Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchGround = true;
        }

        if (collision.gameObject.tag == "PizzeriaPlatform")
        {
            touchGround = true;
            //flagPizzeria.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchGround = false; // rimouvere in futuro quando la pizzeria system funziona
        }

        if (collision.gameObject.tag == "PizzeriaPlatform")
        {
            touchGround = false; // rimouvere in futuro quando la pizzeria system funziona
        }
    }


    #endregion


    public void ScreenLimit()
    {
        Vector2 position = transform.position;
        
        if(transform.position.y > maxScreenUp)
        {
            position.y = maxScreenUp;
        }

        if(transform.position.x < maxScreenLeft)
        {
            position.x = maxScreenLeft;
        }

        if(transform.position.x > maxScreenRight)
        {
            position.x = maxScreenRight;
        }

        transform.position = position;
    }

    public void Update()
    {
        // Thrust();
        ScreenLimit();
    }

    public void FixedUpdate()
    {
         Thrust();
        ThrustMobile();
        //TrustOption2();
        //Thrust2();
        //MobileInputs();
        //ThrustAcc();
        //aggiungere fisica
    }
}
