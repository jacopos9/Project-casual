using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int PizzaInBox;
    public static float genericTimer;
    public static int coins;
    public static GameManager instance; //singleton

    public static int maxPizzaInBox = 10;
    public static int minPizzaInBox = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(transform.root.gameObject); // <------ potrebbe dare problemi 
        }
        
        else
        {
           // Destroy(transform.root.gameObject);
            return;
        }
    }

    private void Start()
    {
        genericTimer = 30f;
        PizzaInBox = 0;
        coins = 0;
    }

    public void AddPizzaInBox() 
    {
        PizzaInBox += 1;
    }

    public void RemovePizzaInBox() 
    {
        PizzaInBox -= 1;  

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

        if(genericTimer<= 0f)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(1);
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
        TimeLeft();
    }

    
}
