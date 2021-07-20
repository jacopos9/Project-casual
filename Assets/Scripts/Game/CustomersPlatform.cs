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
    public BoxCollider2D boxColl;
    public Button buttonDelivery;

    private void Start()
    {
        boxColl = GetComponentInChildren<BoxCollider2D>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collisione");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collisione");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.LogError("collisione");

            buttonDelivery.gameObject.SetActive(true);
           
            /*
            if (collision.gameObject.GetComponentInChildren<BoxCollider2D>())
            {
                Debug.LogError("collisione collisione ch");
            }
            */
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.LogError("collisione");

            buttonDelivery.gameObject.SetActive(false);

            /*
            if (collision.gameObject.GetComponentInChildren<BoxCollider2D>())
            {
                Debug.LogError("collisione collisione ch");
            }
            */
        }
    }
}
