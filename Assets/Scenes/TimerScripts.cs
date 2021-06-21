using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScripts : MonoBehaviour
{
    public float maxTimer = 5f;
    float timeLeft;
    public Image image;

    private void Start()
    {
        timeLeft = maxTimer;
        image.gameObject.SetActive(false);
    }

    public void LoadingPreparePizza()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            image.fillAmount = timeLeft / maxTimer;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    private void Update()
    {
        LoadingPreparePizza();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            image.gameObject.SetActive(true);
        }
    }
}
