using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour {

	private GameObject Player;
	private PlayerMovement PM;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		PM = Player.GetComponent<PlayerMovement> ();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Player")) {
			PM.IsJumpEnabled = true;
		}
	}
}
