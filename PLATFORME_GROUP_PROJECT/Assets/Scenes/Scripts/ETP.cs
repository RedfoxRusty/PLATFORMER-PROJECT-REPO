using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

        public void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Rigidbody2D>().MovePosition(new Vector2(95, -15));
    }
}
