using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 7f;

    void Update()
    {
        // Move enemy cars forward
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
