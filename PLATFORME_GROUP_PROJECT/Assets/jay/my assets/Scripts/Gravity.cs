using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity;
    public float terminalVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movedir = new Vector2(0, -1);
        if (GetComponent<PlayerMovement>().grounded == false)
        {
            if (GetComponent<Rigidbody2D>().velocity.magnitude < terminalVelocity)
            {
                GetComponent<Rigidbody2D>().AddForce(gravity * movedir);
            }
        }
        //Debug.Log(GetComponent<PlayerMovement>().grounded);
    }
    
}
