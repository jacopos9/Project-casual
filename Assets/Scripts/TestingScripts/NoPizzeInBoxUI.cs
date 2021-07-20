using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoPizzeInBoxUI : MonoBehaviour
{
    public Text noPizzeInBox_Ui;
    public float disableText;

  
    public void Activate()
    {
        if (GameManager.PizzaInBox > 0)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);

    }

    private void Update()
    {
        //Activate();
    }
}

