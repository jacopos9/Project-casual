using UnityEngine;
using UnityEngine.UI;

public class PizzaInBoxUi : MonoBehaviour
{ 
    public Text pizzeInBox;

    public void Start()
    {
        pizzeInBox.text = "pizze: " + GameManager.PizzaInBox.ToString();
    }

   /*
    public void AddPizzaInBox()
    {
        pizzeInBox.text = GameManager.PizzaInBox.ToString() + "Pizze Attuali : ";
    }
   */

    public void Update()
    {
        pizzeInBox.text = "pizze: " + GameManager.PizzaInBox.ToString();
    }

}
