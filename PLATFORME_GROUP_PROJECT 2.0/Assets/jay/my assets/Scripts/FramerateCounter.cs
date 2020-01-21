using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FramerateCounter : MonoBehaviour
{
    public Text counter;
    float fps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fps = Mathf.RoundToInt((1 / Time.deltaTime) * 1000);
        counter.text = "FPS " + fps / 1000;
    }
}
