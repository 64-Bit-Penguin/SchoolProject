using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    public GameObject Coin;
    public GameObject Wall;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Coin.SetActive(false);
            Wall.SetActive(false);

        }
    }
}
