using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMFunctionCall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int dmg = GetComponent<AMFunctions>().DangbageCalc(420, 69);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
