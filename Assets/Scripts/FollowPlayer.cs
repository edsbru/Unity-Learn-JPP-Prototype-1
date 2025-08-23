using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private bool isPlayer1;
    private Vector3 cameraOffsetBack = new Vector3(0, 5, -9);
    private Vector3 cameraOffsetFront = new Vector3(0, 2, 1);
    private Vector3 chosenCameraOffset;

    void Start()
    {
        chosenCameraOffset = cameraOffsetBack;
    }
    void Update()
    {
        // Check for camera change on player 1
        if (isPlayer1 && Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCameraOffset();

        }

        // Check for camera change on player 2
        if (!isPlayer1 && Input.GetKeyDown(KeyCode.Keypad1))
        {
            ToggleCameraOffset();
        }
    }
    void LateUpdate()
    {
        //Camera offset | adding to the player/vehicle position
        transform.position = player.transform.position + chosenCameraOffset;
    }

    private void ToggleCameraOffset()
    {
        if (chosenCameraOffset == cameraOffsetBack)
        {
            chosenCameraOffset = cameraOffsetFront;
        }
        else
        {
            chosenCameraOffset = cameraOffsetBack;
        }
    }
}
