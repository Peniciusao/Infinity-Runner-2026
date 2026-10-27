using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    //public float MoveSpeed;

    private float MoveX;
    private float MoveY;

    void Update()
    {
        MoveX = Input.GetAxis("Horizontal")*Time.deltaTime*MoveSpeed;
        MoveY = Input.GetAxis("Vertical")*Time.deltaTime*MoveSpeed;

        //print($"Input X: {MoveX} Input Y: {MoveY}");

        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.Translate(MoveX , MoveY , 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            Destroy(this.gameObject);
        }
    }
}