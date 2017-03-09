using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRay : MonoBehaviour {

	private RaycastHit hitInfo;
	private Ray myRay;
	private Vector3 shootOffset;
	private Quaternion rotOffset;
	public Planet thisPlanet;

	void Start(){
		shootOffset = new Vector3(-5,0,0);
		print(transform.position);
		print(thisPlanet.transform.position);
		shootOffset = (transform.position - thisPlanet.transform.position).normalized;
		print(shootOffset);
		rotOffset = Quaternion.LookRotation(shootOffset);
		print(rotOffset);
		Debug.DrawRay(transform.position-shootOffset,shootOffset, Color.cyan);
	}
	void Update () {
		myRay = new Ray(transform.position-shootOffset,shootOffset);	
		Debug.DrawRay(transform.position-shootOffset,shootOffset, Color.cyan);
	}

	void FixedUpdate(){
		if (Physics.Raycast(myRay, out hitInfo))
			print("OHHHH SHIT" + hitInfo.distance);
	}
}
