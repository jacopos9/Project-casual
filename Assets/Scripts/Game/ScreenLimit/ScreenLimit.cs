using UnityEngine;

public class ScreenLimit : MonoBehaviour
{
   // collider che andranno applicati come limite a fine lavoro(test)
    
    public BoxCollider2D dx;
    public BoxCollider2D sx;
    public BoxCollider2D up;
    public BoxCollider2D down;

  /// <summary>
  /// vettori screenSize
  /// </summary>
   public Vector2 upDx;
   public Vector2 downDx;
   public Vector2 downSx;
   public Vector2 upSx;


    private void Start()
    {
       /*
        dx = GetComponentInChildren<BoxCollider2D>();
        sx = GetComponentInChildren<BoxCollider2D>();
        up = GetComponentInChildren<BoxCollider2D>();
        down = GetComponentInChildren<BoxCollider2D>();
       */
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInChildren<BoxCollider2D>())
        {
            Debug.Log("ciao");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       // BoxCollider2D varColl;
    }

    void All()
    {
        //down.size = spacing;

     

    }

    private void Update()
    {
        All();
        
    }


}
