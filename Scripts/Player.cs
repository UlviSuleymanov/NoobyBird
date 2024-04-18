using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    public float flapSpeed = 2.5f;
    public Player player;
    public Rigidbody2D rigidBody2D;
    public Obstacle obstacle;
    private ScoreTracker scoreTracker;
    public TextMeshProUGUI textMeshProUGUI;
    private int points=0;

    private void Awake()
    {
        scoreTracker = obstacle.GetComponentInChildren<ScoreTracker>();
        scoreTracker.SetScore(textMeshProUGUI);
    }
   
    private void FlapWing()
    {
        if(rigidBody2D != null) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
               rigidBody2D.velocity = Vector2.up * flapSpeed;

            }
        }
    }
    private void Update()
    {
        FlapWing();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            points++;
            scoreTracker.UpdateScoreUI(points);
        }
    }

   
}
