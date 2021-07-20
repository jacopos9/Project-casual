using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PizzaInBox; // richiamato per gestire le pizze
    public static float genericTimer; // richiamato in ui 
    public static int coins; // richiamato per incrementare i soldi
    public static GameManager instance; //singleton

    public static int maxPizzaInBox = 10;
    public static int minPizzaInBox = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.root.gameObject); // <------ potrebbe dare problemi 
        }
        
        else
        {
            Destroy(transform.root.gameObject);
            return;
        }
    }

    private void Start()
    {
        genericTimer = 30f;
    }

    public void AddPizzaInBox() //<-- se crea problemi togliere il parametros // forse cambiare e mettere in uno script ui
    {
        PizzaInBox += 1;
    }

    public void RemovePizzaInBox() //<---- richiamata quando il giocatore schiaccerà il pulsante cosegna
    {
        PizzaInBox -= 1;  // <--- sostituta poi dalla variabile intera della richiesta del cliente

        if(PizzaInBox <= minPizzaInBox)
        {
            PizzaInBox = minPizzaInBox;
        }
    }

    
    public void IncreaseCoins(int coin)
    {
        //coins += 100;

        //int random = Random.Range(0, 100);
        //coins += random;
        coins += coin;

        //cambiare poi con i tempi in base di consegna (mettere nei parametri)
    }

    public void IncreaseGenericTimer()
    {
        genericTimer += 5f;
    }

    public void TimeLeft()
    {
        genericTimer -= Time.deltaTime;
    }

    
    public void GameOver()
    {
        // chiamata quando il generic timer scade
        if(genericTimer <= 0f)   // <---- file temporaneo
        {
            Time.timeScale = 0;
        }

    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        //Debug.Log(PizzaInBox);
        TimeLeft();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause();
        }

        //GameOver();
        
    }

    
}
