using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float MoveX;
    private float MoveY;

    void Update()
    {
        MoveX = Input.GetAxis("Horizontal")*Time.deltaTime;
        MoveY = Input.GetAxis("Vertical")*Time.deltaTime;

        transform.Translate(MoveX , MoveY , 0);
    }
}
