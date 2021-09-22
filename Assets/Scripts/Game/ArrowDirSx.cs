using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDirSx : MonoBehaviour // questo è dx in realta,cambiare il nome della classe
{
    public Image arrowSx;
    public bool sx;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "CustomerSx")
        {

            sx = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CustomerSx")
        {

            sx = false;
        }
    }

    public void ArrowTurnOn()
    {
        if (sx)
        {
            arrowSx.color = Color.green;
        }
        else arrowSx.color = Color.white;
    }

    private void Update()
    {
        ArrowTurnOn();
    }

}
