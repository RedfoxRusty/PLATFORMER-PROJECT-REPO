using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lives : MonoBehaviour
{
    public int Lives = 5;
    // Start is called before the first frame update
    void Start()
    {
        Lives--;
    }

    // Update is called once per frame
    void Update()
    {
        if (Lives < 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
