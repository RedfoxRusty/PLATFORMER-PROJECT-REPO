using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health;
    public int lives;
    public Text livestext;

    void Start()
    {
        lives = PlayerPrefs.GetInt("lives");
        livestext.text = "LIVES: " + lives;
    }

    void Update()
    {
        Livesupdate();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            hurt();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy bullet")
        {
            hurt();
        }
    }
    public void hurt()
    {
        lives = PlayerPrefs.GetInt("lives");
        health--;
        if (health < 1)
        {
            if (lives > 0)
            {
                PlayerPrefs.SetInt("lives", lives - 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                SceneManager.LoadScene("gameover");
            }
        }
    }
    public void Livesupdate()
    {
        lives = PlayerPrefs.GetInt("lives");
        livestext.text = "LIVES: " + lives;
    }
}
