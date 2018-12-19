namespace MyStuff {
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Bullet : MonoBehaviour {

		void OnCollisionEnter(Collision col) {
			Debug.LogFormat("Bullet.OnCollisionEnter {0}", col.gameObject.name);
			Destroyable destroyable = col.gameObject.GetComponent<Destroyable>();
			if (destroyable) {
				Destroy(col.gameObject);
			}
		}
	}

}
