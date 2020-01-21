using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformMovement : MonoBehaviour
{
    private GameObject target = null;
    private Vector3 offset;
    void Start()
    {
        target = null;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            target = collision.gameObject;
            offset = transform.position - target.transform.position;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            target = null;
        }
    }
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.transform.position + offset;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
