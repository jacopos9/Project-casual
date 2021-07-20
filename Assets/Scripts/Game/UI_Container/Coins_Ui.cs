using UnityEngine;
using UnityEngine.UI;

public class Coins_Ui : MonoBehaviour
{
    public Text coins;

    private void Start()
    {
        coins.text = "Coins: " + GameManager.coins.ToString();
    }

    private void Update()
    {
        coins.text = "Coins: " + GameManager.coins.ToString();
    }
}
