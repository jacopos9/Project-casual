using UnityEngine;

public class LossCondition : MonoBehaviour
{

    BackGroundMountains backGroundMountains;
    PizzeriaSystem pizzeriaSystem;
    Ground ground;

    private void Start()
    {
        backGroundMountains = FindObjectOfType<BackGroundMountains>();
        pizzeriaSystem = FindObjectOfType<PizzeriaSystem>();
        ground = FindObjectOfType<Ground>();
    }
    public void GameOverCondition()
    {
        if(backGroundMountains.touchMountains || pizzeriaSystem.touchPizzeria || ground.touchGround)
        {
            GameManager.instance.GameOver();
        }
    }
    private void Update()
    {
        GameOverCondition();
    }
}
