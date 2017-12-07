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
            other.transform.position = new Vector3(1000f, 17.25717f, -6.44f);
            yield return new WaitForSeconds(1);
            other.transform.position = new Vector3(2.561f, 1.5f, 2.250336f);
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }


    }
}
