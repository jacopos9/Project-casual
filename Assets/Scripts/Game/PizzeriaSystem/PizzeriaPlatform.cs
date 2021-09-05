using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// classe che gestisce la piattaforma della pizzeria
/// avendo il booleano "playerOnPlatform" gestisce e segna se il player è sulla piattafoma o meno
/// questo booleano sarà poi richiesto da altri scripts per verificare certe condizioni 
/// </summary>
public class PizzeriaPlatform : MonoBehaviour
{
    public bool playerOnPlatform;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerOnPlatform = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerOnPlatform = false;
        }
    }

}
