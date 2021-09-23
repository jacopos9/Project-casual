using UnityEngine;
using UnityEngine.UI;

public class PizzaInBoxUi : MonoBehaviour
{ 
    public Text pizzeInBox;

    public void Start()
    {
        pizzeInBox.text = "" + GameManager.PizzaInBox.ToString();
    }
    public void Update()
    {
        pizzeInBox.text = "" + GameManager.PizzaInBox.ToString();
    }

}
