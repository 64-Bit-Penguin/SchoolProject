using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformscript : MonoBehaviour {

public GameObject Player;
public GameObject Platform;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = Platform.transform;
    }
}
