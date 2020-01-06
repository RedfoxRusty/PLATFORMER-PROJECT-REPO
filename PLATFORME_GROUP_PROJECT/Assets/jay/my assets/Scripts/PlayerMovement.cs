using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 80.0f;
    public float multiplier = 1.0f;
    public float multipliernorm = 1.0f;
    public float multipliermax = 2.0f;
    public float accel;
    float xaxis = 0;
    float yaxis = 0;
    public int doublejump = 0;
    public float jumpforce;
    public int maxjumps;
    public float airmove;
    float movexaxis;
    float stationaryTime = 0;
    public bool grounded = true;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded == true)
        {
            stationaryTime += Time.deltaTime;
            GameObject.Find("Character").GetComponent<Animator>().SetFloat("stationary", stationaryTime);
        }
        else
        {
            stationaryTime = 0;
        }
        if (Input.GetAxisRaw("Horizontal") < 0.25 && Input.GetAxisRaw("Horizontal") > -0.25)
        {
            movexaxis = 0;
            GetComponent<Animator>().SetInteger("x", 0);
            stationaryTime += Time.deltaTime;
        }
        else
        {
            movexaxis = Input.GetAxisRaw("Horizontal");
            GetComponent<Animator>().SetInteger("x", 1);
            stationaryTime = 0;
        }
        if (GetComponent<Rigidbody2D>().velocity.y > 0.05)
        {
            GetComponent<Animator>().SetInteger("y", 1);
        }
        else if (GetComponent<Rigidbody2D>().velocity.y < -0.05)
        {
            GetComponent<Animator>().SetInteger("y", -1);
        }
        else
        {
            GetComponent<Animator>().SetInteger("y", 0);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        Jump();
        Walkrun();
        //float x = Input.GetAxis("Horizontal");
        //Debug.Log(x);
        //float y = Input.GetAxis("Vertical");
        //Debug.Log(y);
        //Vector2 movedir = new Vector2(x, y);
        //movedir.Normalize();
        //GetComponent<Rigidbody2D>().velocity = movedir * (moveSpeed * multiplier);
        //xaxis = GetComponent<Rigidbody2D>().velocity.x;
        //yaxis = GetComponent<Rigidbody2D>().velocity.y;
    }
    void Walkrun()
    {
        if (Input.GetKey(KeyCode.X) && grounded == true)
        {
            multiplier = multipliermax;
            GetComponent<Animator>().SetBool("run", true);
        }
        else
        {
            multiplier = multipliernorm;
            GetComponent<Animator>().SetBool("run", false);
        }
        xaxis = movexaxis;
        Vector2 movedir = new Vector2(xaxis, yaxis);
        if (GetComponent<Rigidbody2D>().velocity.magnitude < (moveSpeed * multiplier) && grounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(accel * movedir * multiplier);
        }
        if (GetComponent<Rigidbody2D>().velocity.magnitude < (moveSpeed * multiplier) && grounded == false)
        {
            GetComponent<Rigidbody2D>().AddForce(accel * movedir * multiplier / airmove);
        }
        if (movexaxis == 0 && grounded == true)
        {
            Vector2 stop = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().velocity = stop;
        }
        //Debug.Log(movexaxis);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //Debug.Log("check1");
            if (doublejump < maxjumps)
            {
                grounded = false;
                Vector2 jumpdir = new Vector2(0, 100);
                GetComponent<Rigidbody2D>().AddForce(jumpdir * jumpforce);
                doublejump += 1;
                //Debug.Log("check2");
            }
            
        }
        if (grounded == true)
        {
            doublejump = 0;
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
            GameObject.Find("Character").GetComponent<Animator>().SetBool("grounded", grounded);
        }
        else if (collision.gameObject.tag == "block" && collision.gameObject.transform.position.y < transform.position.y)
        {
            grounded = true;
            GameObject.Find("Character").GetComponent<Animator>().SetBool("grounded", grounded);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
            GameObject.Find("Character").GetComponent<Animator>().SetBool("grounded", grounded);
        }
        else if (collision.gameObject.tag == "block" && collision.gameObject.transform.position.y < transform.position.y)
        {
            grounded = true;
            GameObject.Find("Character").GetComponent<Animator>().SetBool("grounded", grounded);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = false;
            GameObject.Find("Character").GetComponent<Animator>().SetBool("grounded", grounded);
        }
        else if (collision.gameObject.tag == "block" && collision.gameObject.transform.position.y < transform.position.y)
        {
            grounded = false;
            GameObject.Find("Character").GetComponent<Animator>().SetBool("grounded", grounded);
        }
    }
}
