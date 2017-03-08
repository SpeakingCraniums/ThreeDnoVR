using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour {
	public float gravForce = -10;

	public void Attract(Transform attractedBody){
		
		Vector3 gravityUp = (attractedBody.position - transform.position).normalized;
		Vector3 bodyUp = attractedBody.up;

		attractedBody.GetComponent<Rigidbody>().AddForce(gravityUp * gravForce);

		Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * attractedBody.rotation;
		attractedBody.rotation = Quaternion.Slerp(attractedBody.rotation,targetRotation,50*Time.deltaTime);

	}
}
