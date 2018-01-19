using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float MoveSpeed;
	public float JumpHeight;
	public float CurrentLevel;
	public bool JumpEnabled;

	private Rigidbody rb;
	private float Height;
	private float MaxHeight;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody>();
		MoveSpeed = MoveSpeed;
		JumpHeight = 4f;
		JumpEnabled = false;
		CurrentLevel = 1;

		if (CurrentLevel == 1f) {
			MaxHeight = 0.5f;
		} 
		else if (CurrentLevel == 2f) {
			MaxHeight = 1.29f;
		}
		else if (CurrentLevel == 3f) {
			MaxHeight = 0.647f;
		}
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(MoveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f, MoveSpeed*Input.GetAxis("Vertical") * Time.deltaTime);
		Height = GameObject.Find ("Player").transform.position.y;

		if (Input.GetKeyDown (KeyCode.Space) && Height <= MaxHeight && JumpEnabled) {
			rb.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.Impulse);
		}
    }
}
