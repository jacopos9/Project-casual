using UnityEngine;

/// <summary>
/// classe che si occupa del comportamento della pizza 
/// </summary>
public class Pizza : MonoBehaviour
{
    public PizzeriaPlatform pizzeriaPlatform;
    public float timeBeforeRotten = 0f;
    public float rottenPizza = 3f;
    public float destroyPizza = 10f;
    public Color ColorRottenPizza = Color.green;
    public bool canCatchPizza = true;
    public bool pizzaRotten; //
    // variabili da togliere poi
    public int PizzaInInventory = 0;
    public Sprite SpriteRottenPizza;


    void Start()
    {
        pizzeriaPlatform = FindObjectOfType<PizzeriaPlatform>();
    }

    #region PRIVATE API 
    //CAMBIO DELLA PIZZA 

    private void ChangeColorRottenPizza()
    {
        timeBeforeRotten += Time.deltaTime;

        if(timeBeforeRotten >= rottenPizza)
        {
           // GetComponent<SpriteRenderer>().color = ColorRottenPizza;
            GetComponent<SpriteRenderer>().sprite = SpriteRottenPizza;
        }

        if(timeBeforeRotten >= destroyPizza)
        {
            Destroy(gameObject);
        }
    }

    public void OnMouseDown()
    {
        // spostare
        
        if (Input.GetMouseButton(0))  
        {
            if (canCatchPizza)
            {
                Destroy(gameObject);
                GameManager.instance.AddPizzaInBox();
            }
        }
    }

    public void TestTouchMobile()
    {
         
    }

    private void CatchPizza()
    {
        /*
         if (pizzeriaPlatform.playerOnPlatform)
         {
             if (Input.GetMouseButton(0))
             {
                 Destroy(gameObject);
             }
         }
        */
        if (Input.GetMouseButton(0))
        {
            //  Destroy(gameObject);
            if (canCatchPizza)
            {
                Destroy(gameObject);
            }
        }

        if (timeBeforeRotten <= rottenPizza)
        {
            canCatchPizza = true;
        }
        else canCatchPizza = false;

    }

    // implementare in sistema touch solo sull'oggetto

    #endregion

    #region PUBLIC API

    #endregion

    private void Update()
    {
        ChangeColorRottenPizza();
        //CatchPizza();

        if (timeBeforeRotten <= rottenPizza)
        {
            canCatchPizza = true;
        }
        else canCatchPizza = false;

        #region InputTouch

        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {

            }

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                //Destroy(gameObject);
                }
        }

        if (Input.touchCount == 1)
        {
           // Touch touch = Input.GetTouch(0);
            //Destroy(gameObject);
        }

        #endregion
    }


}
