using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// condizioni di sconfitta
/// </summary>
public class BackGroundMountains : MonoBehaviour
{
    //GameManager gameManager;
    public bool touchMountains;

    private void Awake()
    {
        ///gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        touchMountains = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchMountains = true;
            GameManager.instance.GameOver();
            
        }
    }
}
