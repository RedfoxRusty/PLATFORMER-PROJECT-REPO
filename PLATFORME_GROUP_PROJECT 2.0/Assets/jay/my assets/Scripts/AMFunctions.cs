using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SimpleFunction();
        int dmg = DangbageCalc(420, 69);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SimpleFunction()
    {
        Debug.Log("nyeh");
    }

    public int DangbageCalc(int dangbage, int armor)
    {
        Debug.Log("you deal " + (dangbage-armor) + " dangbage");
        return dangbage - armor;
    }
}
