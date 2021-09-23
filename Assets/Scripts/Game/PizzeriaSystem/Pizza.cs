using UnityEngine;

/// <summary>
/// classe che si occupa del comportamento del GameObject pizza, da qundo viene prodotta
/// fino alla eliminazione
/// </summary>
public class Pizza : MonoBehaviour
{
    float timeBeforeRotten = 0f;
    float timeRottenPizza = 3f;
    float destroyPizza = 10f;
    bool canCatchPizza = true;
    Color RottenPizza = Color.green;
    public Sprite SpriteRottenPizza;
    PizzeriaPlatform pizzeriaPlatform;


    void Start()
    {
        pizzeriaPlatform = FindObjectOfType<PizzeriaPlatform>();
    }

   /// <summary>
   /// funzione usata per cambiare sprite quando passa un tot di tempo
   /// </summary>
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
                GameManager.instance.IncreaseGenericTimer();
            }
        }
    }
    private void CatchPizza()
    {
        if (Input.GetMouseButton(0))
        {
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
    private void Update()
    {
        ChangeColorRottenPizza();
        //CatchPizza();

        if (timeBeforeRotten <= timeRottenPizza)
        {
            canCatchPizza = true;
        }
        else canCatchPizza = false;

    }
}
