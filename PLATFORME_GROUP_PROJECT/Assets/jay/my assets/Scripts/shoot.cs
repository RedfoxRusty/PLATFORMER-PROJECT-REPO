using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootspeed = 10;
    public float bulletlife = 1;
    public float delay = 1.0f;
    float timer = 0;
    Vector2 shootdirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        
   
        shootdirection = new Vector2(0, -1);
        Fire();

        
    }

    public void Fire()
    {
        if (Input.GetKey(KeyCode.Z) && timer > delay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //Vector3 mouseposition = Input.mousePosition;
            //mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            //Vector2 shootdirection = new Vector2(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);
            shootdirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootdirection * shootspeed;
            Destroy(bullet, bulletlife);
        }
    }
}
