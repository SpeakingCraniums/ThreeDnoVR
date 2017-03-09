using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour {

	public float moveSpeed = 2;
	private Vector3 moveDir;
	private Rigidbody thisRigidBody;

	void Update () {
		thisRigidBody = GetComponent<Rigidbody>();
		moveDir = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
	}
	void FixedUpdate(){
		thisRigidBody.MovePosition(thisRigidBody.position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
	}
}

