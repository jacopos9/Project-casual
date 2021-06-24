using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PizzaInBox;
    public static float genericTimer;
    public static GameManager instance; //singleton

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

    public void AddPizzaInBox() //<-- se crea problemi togliere il parametros // forse cambiare e mettere in uno scripts ui
    {
        PizzaInBox += 1;
    }

    public void RemovePizzaInBox() //<---- richiamata quando il giocatore schiaccerà il pulsante cosegna
    {
        PizzaInBox -= 1;
    }

    private void Update()
    {
        //Debug.Log(PizzaInBox);
    }

    //public void RestartScene() { }



}
