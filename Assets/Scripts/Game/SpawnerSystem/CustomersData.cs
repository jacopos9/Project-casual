using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// classe base per la creazione di asset (clienti) principali del gioco in list<11 item>
/// attaccare i prefabs 
/// </summary>
[CreateAssetMenu(fileName = "customers", menuName = "CustomersCreation")]
public class CustomersData : ScriptableObject
{
    public new string name;
    public int order;
    public float timeActive = 30f;
    public Vector2 position;
}

