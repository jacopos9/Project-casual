using UnityEngine;

public class Ground : MonoBehaviour
{
    public bool touchGround;

    private void Start()
    {
        touchGround = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchGround = true;
        }
    }
}
