using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public AudioSource SoundSource;
	public AudioClip Sound;
    public GameObject Player;


	public Vector3 ScreamPosition;
	public Vector3 RespawnPosition;


	void Start()
	{

	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			SoundSource.PlayOneShot(Sound);
			other.transform.position = ScreamPosition;
			yield return new WaitForSeconds(1);
            Player.transform.parent = null;
            other.transform.position = RespawnPosition;
			other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

		}


	}
}
