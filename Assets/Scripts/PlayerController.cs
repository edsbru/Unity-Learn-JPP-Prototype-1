using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwrardInput;
    void Start()
    {
        
    }

    void Update()
    {
        //Player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwrardInput = Input.GetAxis("Vertical");

        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwrardInput);
        //Turn vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
