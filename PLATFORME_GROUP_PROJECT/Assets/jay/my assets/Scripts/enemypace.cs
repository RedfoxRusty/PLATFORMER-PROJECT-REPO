using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypace : MonoBehaviour
{
    float timer = 0.0f;
    public Vector2 movedir0;
    public Vector2 movedir1;
    public Vector2 movedir2;
    public Vector2 movedir3;
    public Vector2 movedir4;
    public Vector2 movedir5;
    public Vector2 movedir6;
    public Vector2 movedir7;
    public Vector2 movedir8;
    public Vector2 movedir9;
    public Vector2 movedir10;
    public Vector2 movedir11;
    public Vector2 movedir12;
    public Vector2 movedir13;
    public Vector2 movedir14;
    public Vector2 movedir15;
    public float movespeed = 1.0f;
    public float pacetime = 3.0f;
    public int cycle = 0;
    // Start is called before the first frame update
    void Start()
    {
        movedir0.Normalize();
        movedir1.Normalize();
        movedir2.Normalize();
        movedir3.Normalize();
        movedir4.Normalize();
        movedir5.Normalize();
        movedir6.Normalize();
        movedir7.Normalize();
        movedir8.Normalize();
        movedir9.Normalize();
        movedir10.Normalize();
        movedir11.Normalize();
        movedir12.Normalize();
        movedir13.Normalize();
        movedir14.Normalize();
        movedir15.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (cycle == 0)
        {
            if (timer > pacetime)
            {
                //movedir0 *= -1;
                timer = 0;
                cycle ++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir0 * movespeed;

        }
        else if (cycle == 1)
        {
            if (timer > pacetime)
            {
                //movedir1 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir1 * movespeed;

        }
        else if (cycle == 2)
        {
            if (timer > pacetime)
            {
                //movedir2 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir2 * movespeed;

        }
        else if (cycle == 3)
        {
            if (timer > pacetime)
            {
                //movedir3 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir3 * movespeed;

        }
        else if (cycle == 4)
        {
            if (timer > pacetime)
            {
                //movedir4 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir4 * movespeed;

        }
        else if (cycle == 5)
        {
            if (timer > pacetime)
            {
                //movedir5 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir5 * movespeed;

        }
        else if (cycle == 6)
        {
            if (timer > pacetime)
            {
                //movedir6 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir6 * movespeed;

        }
        else if (cycle == 7)
        {
            if (timer > pacetime)
            {
                //movedir7 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir7 * movespeed;

        }
        else if (cycle == 8)
        {
            if (timer > pacetime)
            {
                //movedir8 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir8 * movespeed;

        }
        else if (cycle == 9)
        {
            if (timer > pacetime)
            {
                //movedir9 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir9 * movespeed;

        }
        else if (cycle == 10)
        {
            if (timer > pacetime)
            {
                //movedir10 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir10 * movespeed;

        }
        else if (cycle == 11)
        {
            if (timer > pacetime)
            {
                //movedir11 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir11 * movespeed;

        }
        else if (cycle == 12)
        {
            if (timer > pacetime)
            {
                //movedir12 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir12 * movespeed;

        }
        else if (cycle == 13)
        {
            if (timer > pacetime)
            {
                //movedir13 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir13 * movespeed;

        }
        else if (cycle == 14)
        {
            if (timer > pacetime)
            {
                //movedir14 *= -1;
                timer = 0;
                cycle++;
            }
            GetComponent<Rigidbody2D>().velocity = movedir14 * movespeed;

        }
        else if (cycle == 15)
        {
            if (timer > pacetime)
            {
                //movedir15 *= -1;
                timer = 0;
                cycle = 0;
            }
            GetComponent<Rigidbody2D>().velocity = movedir15 * movespeed;

        }
    }
}
