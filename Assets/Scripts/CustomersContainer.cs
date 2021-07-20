using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Customers", menuName ="customers")]
public class CustomersContainer : ScriptableObject  //cambiare questo file con "customersDataContainer"
{
    // dati dei customers 
    public new string name; // nome del personaggio
    public int orderRequest; // numero di pizze richieste
    public float timeToDisable; // tempo di disattivazione
    public GameObject obj;

    // dati del container

    //public List <GameObject> customers = new List<GameObject>();
}
