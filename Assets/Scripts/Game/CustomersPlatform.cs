using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// gestisce il comportamento di ogni singola piattaforma dei clienti
/// box collider
/// </summary>
public class CustomersPlatform : MonoBehaviour
{
    
    /// <summary>
    ///  TODO: togliere i bottoni
    /// importare il sistema di delivery
    /// </summary>
    /// mettere il collider alle piattaforme per detectare il trigger del customers e il player
    
    public BoxCollider2D boxColl;
    public Button buttonDelivery;
    public bool playerInRadius = false;
    public bool customersInRadius = false;
    public bool canDelivery = false;
    public bool delivered = false;
    public float timerStopMoney;
    GameManager gameManager;


    public bool playerOnPlatformCustomers;
    

    private void Start()
    {
        boxColl = GetComponentInChildren<BoxCollider2D>();
        gameManager = GetComponent<GameManager>();

    }

    /// <summary>
    /// metodo usato per controllare se ce il cliente e il player per eseguire la transazione
    /// controllare anche se ci sono le pizze nello zaino (fondamentale)
    /// </summary>
    /// <param name="collision"></param>
    /// ricorddare di mettere il tag e il rigidbody al child anche

    #region competenza Platform 
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Customer" && collision.gameObject.tag == "Player")
        {
            
        }

        if (collision.gameObject.tag == "Customer" || collision.gameObject.tag == "Player")
        {

        }

        if (collision.gameObject.tag == "Player")
        {
            
        }

        if (collision.gameObject.tag == "Customer")
        {
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            playerInRadius = true;
        }

        if(collision.gameObject.tag == "CustomerDx" || collision.gameObject.tag == "CustomerSx")
        {
            customersInRadius = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        

        if (collision.gameObject.tag == "Player")
        {
            playerInRadius = false;
        }

        if(collision.gameObject.tag == "CustomerDx" || collision.gameObject.tag == "CustomerSx")
        {
            customersInRadius = false;
        }

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            canDelivery = false;
        }
    }

    #endregion

    #region DeliverySystem only for testing
    public IEnumerator Delivery()
    {
        yield return new WaitForSeconds(3f);

        if(GameManager.PizzaInBox == 1)
        {
            GameManager.PizzaInBox -= 1;
            delivered = true;
        }

        if(GameManager.PizzaInBox == 2)   // <--- aggiustare meglio
        {
            GameManager.PizzaInBox -= 1;
        }
    }

    public IEnumerator IncreaseMoneyAndTime()
    {
        GameManager.coins += 10;
        GameManager.genericTimer += 1;
        yield return new WaitForSeconds(10);
    }

    private void Update()
    {

        if (playerInRadius && customersInRadius)
        {
            canDelivery = true;
        }
        else canDelivery = false; 

        if (canDelivery)
        {
            StartCoroutine("Delivery");
        }
        else StopCoroutine("Delivery");

        if (delivered)
        {
            timerStopMoney += Time.deltaTime;

            if (timerStopMoney >= 0.2f)
            {
                delivered = false;
                timerStopMoney = 0f;
            }
            StartCoroutine("IncreaseMoneyAndTime");
        }
    }
    #endregion
}
