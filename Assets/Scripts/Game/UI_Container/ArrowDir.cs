using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// classe costruita in questo modo per la futura realizzazione di asset
/// </summary>
public class ArrowDir : MonoBehaviour
{
    public Image arrowDx;
    public Image arrowSx;
    public bool dx;
    public bool sx;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CustomerSx")
        {
            sx = true;
        }

        if (collision.gameObject.tag == "CustomerDx")
        {

            dx = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "CustomerSx")
        {
            sx = false;
        }

        if (collision.gameObject.tag == "CustomerDx")
        {

            dx = false;
        }
    }

    public void ArrowTurnOn()
    {
        
         if (sx)
         {
             arrowSx.color = Color.green;
         }

         if (dx)
         {
             arrowDx.color = Color.green;
         }

        if (!sx)
        {
            arrowSx.color = Color.white;
        }

        if (!dx)
        {
            arrowDx.color = Color.white;
        }
    }

    private void Update()
    {
        ArrowTurnOn();
    }

}
