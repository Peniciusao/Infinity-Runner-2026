using UnityEngine;

public class PMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Input.GetKey(KeyCode.W))
            print("w");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
