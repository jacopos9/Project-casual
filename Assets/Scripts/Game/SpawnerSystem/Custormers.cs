using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// classe che si occupa della gestione del cliente
/// </summary>
public class Custormers : MonoBehaviour
{
    public float timeToDisactive = 300f;
    public float DEBUGTIME = 0f;
    public CustomersPlatform customersPlatform;

    private void Awake()
    {
       customersPlatform = FindObjectOfType<CustomersPlatform>();
    }

    public void Start()
    {
        customersPlatform = FindObjectOfType<CustomersPlatform>();
        StartCoroutine("DisableCustomers");
        
    }

    public void DisableObject()
    {
        
    }

    public IEnumerator DisableCustomers()
    {
        yield return new WaitForSeconds(timeToDisactive);
        gameObject.SetActive(false);
    }

    public void Update()
    {
        DEBUGTIME -= Time.deltaTime;
    }
}
