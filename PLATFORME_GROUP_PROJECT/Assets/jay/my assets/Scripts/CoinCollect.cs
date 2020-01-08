using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public int Coin = 0;
    public int goal;
    public Text cointext;

    void Start()
    {
        Coin = PlayerPrefs.GetInt("coins");
        cointext.text = "COINS " + Coin + "/" + goal;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            PlayerPrefs.SetInt("coins", Coin + 1);
            GameObject.Find("player rusty").GetComponent<PlayerHP>().health++;
            GameObject.Find("player rusty").GetComponent<PlayerHP>().Healthupdate();
            Coin = PlayerPrefs.GetInt("coins");
            cointext.text = "coins " + Coin + "/" + goal;
            Destroy(collision.gameObject);
            if (Coin > goal - 1)
            {
                GameObject.Find("blocked root").GetComponent<unlock>().Unlock();
            }
        }
        
    }
}

