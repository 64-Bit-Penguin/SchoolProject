using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelScript : MonoBehaviour {


    [SerializeField] private string NextLevel;

    public GameObject LevelActivate;
    public GameObject LevelDeactivate;
    public Vector3 LevelPosition;


    void Start()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LevelActivate.SetActive(true);
            LevelDeactivate.SetActive(false);
            other.transform.position = LevelPosition;
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }


    }
}
