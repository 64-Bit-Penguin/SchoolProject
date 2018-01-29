using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchScript : MonoBehaviour {

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;

    public bool a1;
    public bool a2;
    public bool a3;
    public bool a4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cam1.SetActive(a1);
            Cam2.SetActive(a2);
            Cam3.SetActive(a3);
            Cam4.SetActive(a4);
        }
    }
}
