using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    //Health
    public int maxHealth = 100;
    public int currentHealth;

    public float deathDelay = 2f;
    public GameObject deathEffect;

    private float deathTime;

    //Movement

    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;

    void Start()
    {
        //Health
        currentHealth = maxHealth;
        //Movement
        rb = GetComponent<Rigidbody2D>();
    }

    //Health
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

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    //Movement
    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
