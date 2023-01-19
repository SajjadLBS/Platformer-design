using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{

    public GameObject player;
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
        if (other.gameObject.CompareTag("Player"))
        {
            Scene currenteScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currenteScene.name);
        }
    }
}
