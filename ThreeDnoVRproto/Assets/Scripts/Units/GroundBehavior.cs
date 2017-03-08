using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehavior : MonoBehaviour {

	public GravityAttractor fauxGravity;
	private Transform myTransform;
	private Rigidbody unitBody;

	void Start(){
		unitBody = GetComponent<Rigidbody>();
		unitBody.constraints = RigidbodyConstraints.FreezeRotation;
		unitBody.useGravity = false;
		myTransform = transform;
	}

	void Update(){
		fauxGravity.Attract(myTransform);
	}
}
