using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLVL : MonoBehaviour {

    [SerializeField] private string NextLevel;

    public GameObject Level2;
    public GameObject Level1;


    void Start()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Level2.SetActive(true);
            Level1.SetActive(false);
            other.transform.position = new Vector3(15.31271f, 1.35f, 2.742641f);
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }

        
    }

}
