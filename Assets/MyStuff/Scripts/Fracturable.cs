using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracturable : MonoBehaviour {

	public GameObject fractured;
	public AudioSource fractureSound;

	public void Fracture() {
		Instantiate(fractured, transform.position, transform.rotation);
		Destroy(gameObject);
		fractureSound.Play();
	}

	void OnMouseDown() {
		Fracture();
	}
}
