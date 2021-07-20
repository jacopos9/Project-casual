using UnityEngine;

/// <summary>
/// classe che si occupa del comportamento della pizza 
/// </summary>
public class Pizza : MonoBehaviour
{
    public PizzeriaPlatform pizzeriaPlatform;
    public float timeBeforeRotten = 0f;
    public float timeRottenPizza = 3f;
    public float destroyPizza = 10f;
    public Color ColorRottenPizza = Color.green;
    public bool canCatchPizza = true;
    public bool pizzaRotten; //
    // variabili da togliere poi
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

        if(timeBeforeRotten >= timeRottenPizza)
        {
            GetComponent<SpriteRenderer>().sprite = SpriteRottenPizza;
            
            if(timeBeforeRotten >= destroyPizza)
            {
                Destroy(gameObject);
            }
        }
    }

    public void OnMouseDown()
    {
      
        if (Input.GetMouseButton(0))  
        {
            if (canCatchPizza)
            {
                Destroy(gameObject);
                GameManager.instance.AddPizzaInBox();
                //GameManager.instance.IncreaseCoins(50);
                GameManager.instance.IncreaseGenericTimer();
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

        if (timeBeforeRotten <= timeRottenPizza)
        {
            canCatchPizza = true;
        }
        else canCatchPizza = false;

    }

   

    #endregion

    #region PUBLIC API

    #endregion

    private void Update()
    {
        ChangeColorRottenPizza();
        //CatchPizza();

        if (timeBeforeRotten <= timeRottenPizza)
        {
            canCatchPizza = true;
        }
        else canCatchPizza = false;

        #region InputTouch
        #endregion
    }


}
