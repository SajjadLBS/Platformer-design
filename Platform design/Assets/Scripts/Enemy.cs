using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;
    public float damageDelay = 1f;
    private float lastDamageTime;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (Time.time >= lastDamageTime + damageDelay)
            {
                lastDamageTime = Time.time;
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
