using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Classe che gestisce la pizzeria 
/// instanzia le pizze
/// </summary>
public class PizzeriaSystem : MonoBehaviour
{
    public GameObject pizza;
    public Button preparationPizzaButton;
    public bool touchPizzeria;

    bool courotineCanRun;
    float timeToPreparePizza = 3f;
    int pizzaPrepareCounter = 0;
    PizzeriaPlatform pizzeriaPlatform;

    private void Start()
    {
        pizzeriaPlatform = FindObjectOfType<PizzeriaPlatform>();
        touchPizzeria = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchPizzeria = true;
        }
    }

    public void AppairButton()
    {
        if (pizzeriaPlatform.playerOnPlatform)
        {
            preparationPizzaButton.gameObject.SetActive(true);
            
        }
        else preparationPizzaButton.gameObject.SetActive(false);
    }
   
    public IEnumerator PreparingPizza()
    {
        
         if(pizzeriaPlatform.playerOnPlatform && GameManager.PizzaInBox < 2)
         {
             courotineCanRun = true;
             yield return new WaitForSeconds(timeToPreparePizza);

             Instantiate(pizza, new Vector2(Random.Range(-3f, -3.0f),.10f), transform.rotation);
             pizzaPrepareCounter += +1;

             yield return new WaitForSeconds(.5f);
             courotineCanRun = false;
         }

        if (!pizzeriaPlatform.playerOnPlatform)
        {
            // bloccare la coroutine
        }
    }
    public void AppairLoadingBar() // prossimamente
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
    }
}
