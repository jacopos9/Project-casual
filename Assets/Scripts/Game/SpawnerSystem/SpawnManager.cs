using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// classe base che si occupa dello spawn dei clienti
/// </summary>
public class SpawnManager : MonoBehaviour
{

    public float startTimer = 0f;
    public float spawnTimer = 3f;
    public int currentCustomersActive;
    public List<Vector2> positionSpawn = new List<Vector2>();
    public GameObject[] customer = null;
    public GameObject go;
    public ObjectCustomersData objectCustomersData;
    public CustomersData customersData;


    public void Start()
    {
        customer = new GameObject[objectCustomersData.customers.Count];
        

        for (int i = 0; i < objectCustomersData.customers.Count; i++)
        {
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
            startTimer = 0f;
            //if(currentCustomersActive)
            //Debug.Log(currentCustomersActive);
            //Debug.Log(randomActive);
        }
    }

    private void Update()
    {
        ObjectRandomActive();
    }
}
