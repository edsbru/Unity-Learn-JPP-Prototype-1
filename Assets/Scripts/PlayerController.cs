using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int playerNum;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        //Player input
        if (playerNum == 1)
        {
            horizontalInput = Input.GetAxis("Horizontal_P1");
            forwardInput = Input.GetAxis("Vertical_P1");
        }
        if (playerNum == 2)
        {
            horizontalInput = Input.GetAxis("Horizontal_P2");
            forwardInput = Input.GetAxis("Vertical_P2");
        }
        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turn vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}