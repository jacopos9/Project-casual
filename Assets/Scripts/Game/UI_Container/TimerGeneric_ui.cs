using UnityEngine;
using UnityEngine.UI;

public class TimerGeneric_ui : MonoBehaviour
{
    public Text genericTimer;


    public void Start()
    {
        genericTimer.text = "Time: " + GameManager.genericTimer.ToString();
    }

    public void Update()
    {
        genericTimer.text = "Time: " + GameManager.genericTimer.ToString("0");
    }
}
