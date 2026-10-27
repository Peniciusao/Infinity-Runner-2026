using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float speedX;

    private void Start()
    {
        transform.position = new Vector2(10f,-3.6f);
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.Translate(-speedX*Time.deltaTime, 0, 0);
    }
}
