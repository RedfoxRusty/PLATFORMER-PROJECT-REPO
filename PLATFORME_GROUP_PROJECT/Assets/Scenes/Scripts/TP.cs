using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TP")
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.gameObject.tag == "tp")
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
