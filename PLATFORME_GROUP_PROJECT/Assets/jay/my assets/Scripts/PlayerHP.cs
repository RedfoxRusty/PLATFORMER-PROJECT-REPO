using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health;
    public int maxhp;
    public Text hptext;
    public Slider hpslider;
    public int lives;
    public Text livestext;
    public int counter;

    void Start()
    {
        lives = PlayerPrefs.GetInt("lives");
        livestext.text = "LIVES " + lives;
        hpslider.maxValue = maxhp;
        hpslider.value = health;
        hptext.text = "HP " + health + "/" + maxhp;
        GetComponent<Animator>().SetFloat("hp", health);
    }

    void Update()
    {
        Livesupdate();
        if (counter == 5)
        {
            PlayerPrefs.SetInt("lives", lives + 1);
            Livesupdate();
            counter = 0;
        }
        else if (health > maxhp)
        {
            health = maxhp;
            Healthupdate();
            counter++;
        }
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
        GetComponent<Animator>().SetFloat("hp", health);
        Healthupdate();
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
    public void Healthupdate()
    {
        hpslider.value = health;
        hptext.text = "HP " + health + "/" + maxhp;
    }
    public void Livesupdate()
    {
        lives = PlayerPrefs.GetInt("lives");
        livestext.text = "LIVES " + lives;
    }
}
