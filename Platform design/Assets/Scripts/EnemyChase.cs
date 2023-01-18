using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float chaseRadius = 5f;
    public float chaseSpeed = 5f;
    public Transform player;

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < chaseRadius)
        {
            // Move towards the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);
        }
    }
}