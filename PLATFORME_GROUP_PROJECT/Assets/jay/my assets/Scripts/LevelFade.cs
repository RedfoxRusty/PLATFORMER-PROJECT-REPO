using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFade : MonoBehaviour
{
    public Animator animator;
    public string lvlName;
    string nxtlvl;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Fade(lvlName);
        //}
    }
    public void run()
    {
        Fade(lvlName);
    }

    public void Fade(string lvlname)
    {
        nxtlvl = lvlname;
        animator.SetTrigger("fadetrigger");
    }

    public void Finfade()
    {
        SceneManager.LoadScene(nxtlvl);
    }
}
