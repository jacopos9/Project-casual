using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// classe base che si occupa dello spawn dei clienti
/// </summary>
public class SpawnManager : MonoBehaviour
{
    //public float startTimer = 0f;
    //public float spawnTimer = 3f;
    //public List<Vector2> spawnPosition = new List<Vector2>();
   // CustomersData customersData;

    // public ObjectCustomersData // scriptable che 
    public ObjectCustomersData objectCustomersData;
    public List<Vector2> positionSpawn = new List<Vector2>();
    public CustomersData customersData;
    public float startTimer = 0f;
    public float spawnTimer = 3f;
    public GameObject[] customer = null;
    public GameObject go;
    public int currentCustomersActive;


    public void Start()
    {
        customer = new GameObject[objectCustomersData.customers.Count];

        for (int i = 0; i < objectCustomersData.customers.Count; i++)
        {
          
            customer[i] = go = Instantiate(objectCustomersData.customers[i]);
            go.SetActive(false);
            // cambiare la posizione
        }
    }

    public void ObjectRandomActive()
    {
        startTimer += Time.deltaTime;

        if(startTimer >= spawnTimer)
        {
            int randomActive = Random.Range(0, objectCustomersData.customers.Count);
            customer[randomActive].SetActive(true);
            startTimer = 0f;
        }
    }

    private void Update()
    {
        ObjectRandomActive();
    }
}
