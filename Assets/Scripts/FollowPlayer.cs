using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    void LateUpdate()
    {
        //Camera offset | adding to the player/vehicle position
        transform.position = player.transform.position + cameraOffset;
    }
}
