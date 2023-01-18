using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public float deathDelay = 2f;
    public GameObject deathEffect;

    private float deathTime;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        deathTime = Time.time;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        gameObject.SetActive(false);

    }
}
