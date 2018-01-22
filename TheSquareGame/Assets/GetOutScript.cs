using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOutScript : MonoBehaviour {

    public GameObject Player;
    

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = null;
    }
}
