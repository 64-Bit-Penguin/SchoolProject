using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float MoveSpeed;
	public float JumpHeight;

	public bool JumpEnabled;
	public bool IsJumpEnabled;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody>();
		MoveSpeed = 4f;
		JumpHeight = 4f;
		JumpEnabled = false;
	}

	// Update is called once per frame
	void Update () {

			transform.Translate(MoveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f, MoveSpeed*Input.GetAxis("Vertical") * Time.deltaTime);


			if (Input.GetKeyDown (KeyCode.Space) && IsJumpEnabled == true && JumpEnabled == true) {
				rb.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.Impulse);
				IsJumpEnabled = false;
			}

    }

}
