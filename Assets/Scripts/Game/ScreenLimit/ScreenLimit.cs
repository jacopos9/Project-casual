using UnityEngine;

public class ScreenLimit : MonoBehaviour
{
   // collider che andranno applicati come limite a fine lavoro(test)
    
    public BoxCollider2D dx;
    public BoxCollider2D sx;
    public BoxCollider2D up;
    public BoxCollider2D down;

    // vettori di dimensione schermo
   public Vector2 upDx;
   public Vector2 downDx;
   public Vector2 downSx;
   public Vector2 upSx;


    void All()
    {
        //down.size = spacing;

     

    }

    private void Update()
    {
        All();
        
    }


}
