using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldPoint : MonoBehaviour {
	RaycastHit hit;
	Ray ray;

	void OnMouseDown()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray,out hit))
		{
			Vector3 pointHit = hit.point;
			pointHit -= GetComponent<Collider>().gameObject.transform.position;
			// just convert to a vector2
			//Vector2 v2HitPoint = (Vector2)pointHit;

			// remember that this is just the X and Y values relative to spheres centre point.
			Debug.Log("V2 local position hit : " + pointHit);
		}
	}
}