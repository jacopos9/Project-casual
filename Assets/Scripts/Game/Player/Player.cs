using UnityEngine;

namespace js.SpacePlatformGame
{
    public class Player : MonoBehaviour
    {
        //classe generica base che si occupa del controller in modo più generico rispetto alla superclasse (player controller),
        // che invece si occuperà di gestire il player specifico di questo gioco

        public float speed;

        public float horizontalSpeed { get; set; }

        /*
        public Player(float p_horizontalSpeed)
        {
            horizontalSpeed = p_horizontalSpeed;
        }
        */

    }
}

