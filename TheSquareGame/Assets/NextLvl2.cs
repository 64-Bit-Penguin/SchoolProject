using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvl2 : MonoBehaviour {

    [SerializeField] private string NextLevel;

    public GameObject Level3;
    public GameObject Level2;
    public GameObject Level1;


    void Start()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Level2.SetActive(false);
            Level1.SetActive(false);
            Level3.SetActive(true);
            other.transform.position = new Vector3(15.31271f, 1.35f, 2.742641f);
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }


    }
}
