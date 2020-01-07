using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Vector2 movedir;
    public float range = 0.0f;
    public float movespeed = 1.0f;
    float Zaxis;
    Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        movedir.Normalize();
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 displacement = new Vector2(transform.position.x - startpos.x, transform.position.y - startpos.y);
        if (displacement.magnitude > range)
        {
            movedir *= -1;
            
        }
        transform.position = new Vector3(transform.position.x + ((movedir.x / 100) * movespeed), transform.position.y + ((movedir.y / 100) * movespeed), startpos.z);
    }
}
