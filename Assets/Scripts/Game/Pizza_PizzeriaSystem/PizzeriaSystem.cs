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

    public Button preparationPizzaButton;

    public void Start()
    {
        pizzeriaPlatform = FindObjectOfType<PizzeriaPlatform>();
    }

    public void AppairButton()
    {
        if (pizzeriaPlatform.playerOnPlatform)
        {
            preparationPizzaButton.gameObject.SetActive(true);
            
        }
        else preparationPizzaButton.gameObject.SetActive(false);

        //preparationPizzaButton.gameObject.transform.position = buttonPosition.position
    }

    public IEnumerator PreparingPizza()
    {
        
         if(pizzeriaPlatform.playerOnPlatform && GameManager.PizzaInBox < 2) //controllare il trasporto massimo di pizze
         {
             courotineCanRun = true;
             yield return new WaitForSeconds(timeToPreparePizza);

             Instantiate(pizza, new Vector2(Random.Range(-3.5f, -3.0f),-2f), transform.rotation);
            // GameObject go = Instantiate(pizza, new Vector2(Random.Range(-3.5f, -3.0f), SpawnPizzaPosition.y), transform.rotation);

             yield return new WaitForSeconds(.5f);
             courotineCanRun = false;
         }
        

        if (!pizzeriaPlatform.playerOnPlatform)
        {
            // bloccare la coroutine
        }
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
    }

}
