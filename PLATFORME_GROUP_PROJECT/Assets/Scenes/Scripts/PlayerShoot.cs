using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public int pow = 0;
    public GameObject prefab;
    public float shootSpeed = 10.0f;
    public float bulletLifetime = 3.0f;
    public float shootDelay = 1.0f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pow == 1)
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Z) && timer > shootDelay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //get mouse positon in x, y pixels on the screen
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("Mouse position 1: " + mousePosition);
            //convert x, y pixels to game world position
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("Mouse position 2: " + mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime); 
        }  
    }
        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pow")
        {
            pow++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "enemy")
        {
            pow--;
        }
    }
    

}
