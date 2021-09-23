using UnityEngine;
using System.Collections;

public class DeliverySystem : MonoBehaviour
{
   /*
    CustomersPlatform customersPlatform;
    public float TimerStopMoney;
    public bool CanDelivery = false;
    public bool Delivered = false;

    private void Start()
    {
        customersPlatform = FindObjectOfType<CustomersPlatform>();
    }

    public IEnumerator Delivery()
    {
        yield return new WaitForSeconds(3f);

        if (GameManager.PizzaInBox == 1)
        {
            GameManager.PizzaInBox -= 1;
           customersPlatform.delivered = true;
        }

        if (GameManager.PizzaInBox == 2)
        {
            GameManager.PizzaInBox -= 1;
        }
    }

    public IEnumerator IncreaseMoneyAndTime()
    {
        GameManager.coins += 10;
        GameManager.genericTimer += 1;
        yield return new WaitForSeconds(10);
    }

    private void Update()
    {

        if (customersPlatform.playerInRadius && customersPlatform.customersInRadius)
        {
            customersPlatform.canDelivery = true;
        }
        else customersPlatform.canDelivery = false;

        if (customersPlatform.canDelivery)
        {
            StartCoroutine("Delivery");
        }
        else StopCoroutine("Delivery");

        if (customersPlatform.delivered)
        {
            TimerStopMoney += Time.deltaTime;

            if (TimerStopMoney >= 0.2f)
            {
                customersPlatform.delivered = false;
                TimerStopMoney = 0f;
            }
            StartCoroutine("IncreaseMoneyAndTime");
        }
    }
   */
}
