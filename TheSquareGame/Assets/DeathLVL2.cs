using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLVL2 : MonoBehaviour {

    public AudioSource SoundSource;
    public AudioClip Sound;



    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundSource.PlayOneShot(Sound);
            other.transform.position = new Vector3(10000f, 17000.25717f, -600.44f);
            yield return new WaitForSeconds(1);
            other.transform.position = new Vector3(2.561f, 1.6f, 2.250336f);
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }


    }
}
