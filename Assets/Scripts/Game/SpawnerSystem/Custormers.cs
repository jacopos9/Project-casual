using System.Collections;
using UnityEngine;

/// <summary>
/// classe che si occupa della gestione del cliente
/// </summary>
public class Custormers : MonoBehaviour
{
    float timeToDisactive = 15f;
    public float DEBUGTIME = 0f;
    public CustomersPlatform customersPlatform;
    public bool isActive = true;

    private void Awake()
    {
       customersPlatform = FindObjectOfType<CustomersPlatform>();
    }

    public void Start()
    {
        customersPlatform = FindObjectOfType<CustomersPlatform>();
        StartCoroutine("DisableCustomers");
        isActive = true;
    }

    public void DisableObject()
    {
        
    }

    public IEnumerator DisableCustomers()
    {
        yield return new WaitForSeconds(timeToDisactive);
        gameObject.SetActive(false);
        isActive = false;
    }

    public void Update()
    {
        DEBUGTIME -= Time.deltaTime;

        if (isActive == false)
        {
            DEBUGTIME = 0f;
        }
    }
}
