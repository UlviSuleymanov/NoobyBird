using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    public GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }


   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            manager.SetDead();
            Time.timeScale = 0f;
        }
    }
}
