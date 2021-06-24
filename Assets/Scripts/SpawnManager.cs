using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> customers;
    public List<Vector2> spawnPosition;
    public float SpawnerTimer;
    public int customersSpawned;


    private void Start()
    {
        for (int i = 0; i < customers.Count; i++)
        {
            customers[i].SetActive(false);

            customers[0].transform.position = spawnPosition[0];
            customers[1].transform.position = spawnPosition[1];
            customers[2].transform.position = spawnPosition[2];
            customers[3].transform.position = spawnPosition[3];
            customers[4].transform.position = spawnPosition[4];
            customers[5].transform.position = spawnPosition[5];
            customers[6].transform.position = spawnPosition[6];
            customers[7].transform.position = spawnPosition[7];
            customers[8].transform.position = spawnPosition[8];
            customers[9].transform.position = spawnPosition[9];
        }
    }


    public void CustomersSpawner()
    {
        SpawnerTimer += Time.deltaTime;

        if (SpawnerTimer > 5f)
        {
            int randomActive = Random.Range(0, customers.Count);
            customers[randomActive].SetActive(true);
            SpawnerTimer = 0f;
        }
    }

    private void Update()
    {
        CustomersSpawner();
    }
}
