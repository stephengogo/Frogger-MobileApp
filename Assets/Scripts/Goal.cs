using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Goal : MonoBehaviour
{
    private GameObject frogPlayer;
    private Vector3 playerInitialPos;

    public Text scoreText;
    private int score;

    void Awake()
    {
        frogPlayer = GameObject.FindWithTag("Player");
        playerInitialPos = frogPlayer.transform.position;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.transform.position = playerInitialPos;
            score += 100;
            scoreText.text = score.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
