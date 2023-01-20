    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{

    public GameObject enemy;
    public Transform respawnPoint;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
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

1
