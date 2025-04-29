using UnityEngine;

public class MonsterFollowPlayer : MonoBehaviour
{
    public Transform player; // Drag your player or camera here
    public float speed = 2.0f; // Movement speed

    void Update()
    {
        if (player != null)
        {
            // Calculate the target position (keep Y locked)
            Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);

            // Calculate distance to player
            float distance = Vector3.Distance(transform.position, targetPosition);

            // Only move if farther than stopDistance
            float stopDistance = 1.0f; // you can tweak this number

            if (distance > stopDistance)
            {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    targetPosition,
                    speed * Time.deltaTime
                );
            }
        }
    }
}
