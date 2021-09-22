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
    public CustomersData customersData;
    public float startTimer = 0f;
    public float spawnTimer = 3f;
    public int currentCustomersActive; // <-- int che capisce l'istanza attiva e la passa al bool che controlla il gamaObject da disativare
    public List<Vector2> positionSpawn = new List<Vector2>();
    public GameObject[] customer = null;
    public GameObject go;


    public void Start()
    {
        customer = new GameObject[objectCustomersData.customers.Count];
        

        for (int i = 0; i < objectCustomersData.customers.Count; i++)
        {
            //objectCustomersData.customers[0].transform.position = positionSpawn[0]; cambio di position
          
            customer[i] = go = Instantiate(objectCustomersData.customers[i]);
            go.SetActive(false);
        }

        for (int i = 0; i < 11; i++)
        {
            objectCustomersData.customers[i].transform.position = positionSpawn[i];
        }

    }

    public void ObjectRandomActive()
    {
        startTimer += Time.deltaTime;

        if(startTimer >= spawnTimer)
        {
            int randomActive = Random.Range(0, objectCustomersData.customers.Count);
            currentCustomersActive = randomActive;
            customer[randomActive].SetActive(true);
            Debug.Log(randomActive);
            Debug.Log(currentCustomersActive);
            startTimer = 0f;
        }
    }

    private void Update()
    {
        ObjectRandomActive();
    }
}
