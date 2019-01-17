using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Fracturable))]
public class FractureOnCollision : MonoBehaviour {

	public int fractureVelocity;
	Fracturable fracturable;

	void Start() {
		fracturable = GetComponent<Fracturable>();
	}
	void OnCollisionEnter(Collision col) {
		Debug.LogFormat("FractureOnCollision.OnCollisionEnter: {0}", col.relativeVelocity.magnitude);
		if (col.relativeVelocity.magnitude >= fractureVelocity) {
			fracturable.Fracture();
		}
	}
}
