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
			Vector3 pointHit = hitInfo.point;
			pointHit -= GetComponent<CylinderRay>().gameObject.transform.position;
			// just convert to a vector2
			Vector2 v2HitPoint = (Vector2)pointHit;

			// remember that this is just the X and Y values relative to spheres centre point.
			Debug.Log("V2 local position hit : " + v2HitPoint);
			Debug.Log("also printing :" + pointHit);
	}
}
}
