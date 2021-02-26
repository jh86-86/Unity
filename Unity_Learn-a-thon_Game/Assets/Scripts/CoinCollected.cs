using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCollected : MonoBehaviour
{
    //public Transform player;
    public Text collectedText;
    public GameObject p;

    void Update()
    {
        collectedText.text = "Coins Collected: " + p.GetComponent<PlayerCollision>().points.ToString();
    }
}
