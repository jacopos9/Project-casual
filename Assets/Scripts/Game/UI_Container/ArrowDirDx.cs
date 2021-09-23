using UnityEngine;
using UnityEngine.UI;

public class ArrowDirDx : MonoBehaviour
{
    public Image arrowDx;
    bool dx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CustomerDx")
        {
            dx = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CustomerDx")
        {
            dx = false;
        }
    }

    public void ArrowTurnOn()
    {
        if (dx)
        {
            arrowDx.color = Color.green;
        }
        else arrowDx.color = Color.white;
    }

    private void Update()
    {
        ArrowTurnOn();
    }

}
