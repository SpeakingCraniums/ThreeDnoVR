using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRay : MonoBehaviour {

	private RaycastHit hitInfo;
	private Ray myRay;
	private Transform hitPlanetPoint;

	void Start(){
		myRay = new Ray(transform.position, Vector3.left);
	}
	void Update () {
	}

	void FixedUpdate(){
		if (Physics.Raycast(myRay, out hitInfo)){
			Vector3 pointHit = hitInfo.textureCoord2;
			Debug.Log("also printing :" + pointHit);
		}
	}
}
