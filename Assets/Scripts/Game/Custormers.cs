using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Custormers : MonoBehaviour
{
    public float timeToDisactive = 3f;
    public float DEBUGTIME = 0f;

    public void Start()
    {
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
