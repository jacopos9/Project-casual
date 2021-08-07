using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// classe che gestisce la lista degli oggetti clienti
/// </summary>

[CreateAssetMenu(fileName ="Data",menuName ="DataContent")]
public class ObjectCustomersData : ScriptableObject
{
    public List<GameObject> customers = new List<GameObject>();
}
