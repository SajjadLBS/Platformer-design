using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy Follow
    public float speed;
    private Transform player;
    public float lineOfSight;
    //Enemy Health
    public int maxHealth = 100;
    int currentHealth;
   

    void Start()
    {

        //Enemy Follow
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //Enemy Health
        currentHealth = maxHealth;

    }

    //Enemy Health
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }

    }
    //Enemy Health

    void Die()
    {
        Debug.Log("Enemy Died!");

        //Disable Enemy

    }



    void Update()
    {
        //Enemy Follow
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if ( distanceFromPlayer < lineOfSight)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
       
    }
    
    //Enemy Follow
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSight);
    
    }
}