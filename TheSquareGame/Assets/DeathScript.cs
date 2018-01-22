using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public AudioSource SoundSource;
	public AudioClip Sound;


	public Vector3 ScreamPosition;
	public Vector3 RespawnPosition;


	void Start()
	{
		ScreamPosition = new Vector3 (1000f, 17.25717f, -6.44f);
		RespawnPosition = new Vector3 (0f, 0f, 0f);
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			SoundSource.PlayOneShot(Sound);
			other.transform.position = ScreamPosition;
			yield return new WaitForSeconds(1);
			other.transform.position = RespawnPosition;
			other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

		}


	}
}
