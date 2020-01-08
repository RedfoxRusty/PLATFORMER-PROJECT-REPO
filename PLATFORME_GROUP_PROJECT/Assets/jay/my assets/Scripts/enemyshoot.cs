using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootspeed = 10;
    public float bulletlife = 1;
    public float delay = 1.0f;
    public float range = 10;
    float timer = 0;
    public Transform player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootdirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (timer > delay && shootdirection.magnitude < range)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mouseposition = Input.mousePosition;
            mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            shootdirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootdirection * shootspeed;
            Destroy(bullet, bulletlife);
        }
    }
}
