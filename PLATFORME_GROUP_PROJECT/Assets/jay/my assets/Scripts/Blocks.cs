using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public string bloktype;
    public string subtype;
    public GameObject powerup1;
    public GameObject powerup2;
    public GameObject powerup3;
    public GameObject coin1;
    public GameObject coin2;
    public float launchpower = 1;
    private GameObject itemtospawn;
    Vector2 direction;
    public bool hit;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(0, 1);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (bloktype == "?")
        {
            GetComponent<Animator>().SetInteger("blocktype", 0);
        }
        else if (bloktype == "!")
        {
            GetComponent<Animator>().SetInteger("blocktype", 1);
        }
        else if (bloktype == "e?")
        {
            GetComponent<Animator>().SetInteger("blocktype", 2);
        }
        else if (bloktype == "b")
        {
            GetComponent<Animator>().SetInteger("blocktype", 3);
        }
        else if (bloktype == "eb")
        {
            GetComponent<Animator>().SetInteger("blocktype", 4);
        }
        else if (bloktype == "h")
        {
            GetComponent<Animator>().SetInteger("blocktype", 5);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && GameObject.FindWithTag("Player").transform.position.y < transform.position.y)
        {
            hit = true;
            GetComponent<Animator>().SetBool("hit", hit);
            if (bloktype == "?")
            {
                if (subtype == "i")
                {
                    itemtospawn = powerup1;
                    GameObject spawn = Instantiate(itemtospawn, transform.position, Quaternion.identity);
                    spawn.GetComponent<Rigidbody2D>().velocity = direction * launchpower;
                    bloktype = "e?";
                }
                else if (subtype == "c")
                {
                    itemtospawn = coin1;
                    GameObject spawn = Instantiate(itemtospawn, transform.position, Quaternion.identity);
                    spawn.GetComponent<Rigidbody2D>().velocity = direction * launchpower;
                    bloktype = "e?";
                }
            }
            else if (bloktype == "!")
            {

            }
            else if (bloktype == "e?")
            {

            }
            else if (bloktype == "b")
            {
                if (subtype == "i")
                {
                    itemtospawn = powerup1;
                    GameObject spawn = Instantiate(itemtospawn, transform.position, Quaternion.identity);
                    spawn.GetComponent<Rigidbody2D>().velocity = direction * launchpower;
                    bloktype = "eb";
                }
                else if (subtype == "c")
                {
                    itemtospawn = coin1;
                    GameObject spawn = Instantiate(itemtospawn, transform.position, Quaternion.identity);
                    spawn.GetComponent<Rigidbody2D>().velocity = direction * launchpower;
                    
                }
            }
            else if (bloktype == "eb")
            {

            }
            else if (bloktype == "h")
            {

            }
        }
        
    }
    public void animstop()
    {
        hit = false;
        GetComponent<Animator>().SetBool("hit", hit);
    }
    public void bloktypeupdate()
    {
        hit = false;
        GetComponent<Animator>().SetBool("hit", hit);
        if (bloktype == "?")
        {
            bloktype = "e?";
        }
        else if (bloktype == "!")
        {
            bloktype = "!";
        }
        else if (bloktype == "e?")
        {
            bloktype = "e?";
        }
        else if (bloktype == "b")
        {
            bloktype = "eb";
        }
        else if (bloktype == "eb")
        {
            bloktype = "eb";
        }
        else if (bloktype == "h")
        {
            bloktype = "h";
        }
    }
}
