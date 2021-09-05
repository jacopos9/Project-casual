using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// classe che gestisce la pizzeria 
/// instanzia le pizze
/// </summary>
public class PizzeriaSystem : MonoBehaviour
{
    public PizzeriaPlatform pizzeriaPlatform;
    public GameObject pizza;
    public bool courotineCanRun;
    public float timeToPreparePizza = 3f;
    public Vector2 SpawnPizzaPosition = new Vector2(-3.3f, -3f); //aggiungere il fatto che spawnano random tra queste 2
    public Vector2 SpawnPizzaPosition2 = new Vector2(-4f, 3f);
    public Transform [] spawnPizzaPos;
    public int pizzaCounter = 0;
    public Transform buttonPosition;

    public int pizzaPrepareCounter = 0;
    public float timeBetweenTwoPizza = 0f;

    public Button preparationPizzaButton;
    public GameObject buttonPrepare;
    
    TimerScripts timerScripts;


    /// <summary>
    /// TODO : mettere un limitatore alla preparazione pizze
    /// se le pizze non vengono raccolte ma restano sulla piattaforma si possono cucinare all'infinito
    /// </summary>

    public void Start()
    {
        pizzeriaPlatform = FindObjectOfType<PizzeriaPlatform>();
        timerScripts = FindObjectOfType<TimerScripts>();
        //GameObject button = GameObject.Find("Preparation_Pizza_Button");
        //Vector2 pos = button.transform.position;
        //pos.x -= 10f;
        //button.transform.position = pos;
    }

    public void AppairButton()
    {
        if (pizzeriaPlatform.playerOnPlatform)
        {
            preparationPizzaButton.gameObject.SetActive(true);
            // timerScripts.image.gameObject.SetActive(true);
           // preparationPizzaButton.transform.position = new Vector2(10f, 0);
            
        }
        else preparationPizzaButton.gameObject.SetActive(false);

        //preparationPizzaButton.gameObject.transform.position = buttonPosition.position

       // Vector2 pos = buttonPrepare.transform.position;

       // pos.x = 0f;
       // buttonPrepare.transform.position = pos;

    }

    public IEnumerator PreparingPizza()
    {
        
         if(pizzeriaPlatform.playerOnPlatform && GameManager.PizzaInBox < 2) //controllare il trasporto massimo di pizze
         {
             courotineCanRun = true;
             yield return new WaitForSeconds(timeToPreparePizza);
            //timerScripts.image.gameObject.SetActive(true);

             Instantiate(pizza, new Vector2(Random.Range(-3.5f, -3.0f),-2f), transform.rotation);
             pizzaPrepareCounter += +1;
            // GameObject go = Instantiate(pizza, new Vector2(Random.Range(-3.5f, -3.0f), SpawnPizzaPosition.y), transform.rotation);

             yield return new WaitForSeconds(.5f);
             courotineCanRun = false;
         }
        

        if (!pizzeriaPlatform.playerOnPlatform)
        {
            // bloccare la coroutine
        }
    }

    public void AppairLoadingBar()
    {

    }

    public void OnButtonClick()
    {
        if (!courotineCanRun)
        {
            StartCoroutine("PreparingPizza");
        }
    }

    public void Update()
    {
        AppairButton();
        
        if(pizzaCounter >= 2)
        {
            Debug.Log("sup");
        }

        #region InTestings

        /*
        if (pizzaPrepareCounter>= 2)
        {
            Debug.Log("superato il limite");
            // stop coroutine 
            //  fa partire il timer che impedisce di far preparare
            // restart coroutine

            StopCoroutine("PreparingPizza");
            timeBetweenTwoPizza += Time.deltaTime;

            if(timeBetweenTwoPizza >= 15f)
            {
                timeBetweenTwoPizza = 0f;
                pizzaPrepareCounter = 0;
                StartCoroutine("PreparingPizza");
            }

        }
        */

        #endregion
    }

}
