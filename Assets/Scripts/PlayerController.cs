using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
