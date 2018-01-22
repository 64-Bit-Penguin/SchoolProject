using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activ_particel : MonoBehaviour {

	public GameObject particle;
	// Use this for initialization
	void Start () {
		
	}
	
	IEnumerator OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("particle")) {
			particle.SetActive (false);
			yield return new WaitForSeconds (2f);
			particle.SetActive (true);

		}
			

	}
}
