namespace MyStuff {

	using UnityEngine;
	using UnityEngine.UI;
    using VRTK;
    using System.Collections.Generic;
	using System.Collections;

	public class Lock2_Data : MonoBehaviour {

		public string passwordAttempt;
		public string password;

        public void AddToAttempt(string _char) {
            passwordAttempt += _char;
        }

        public void UpdateAttempt(string newPwdAttempt) {
            passwordAttempt = newPwdAttempt;
        }

        public bool CheckAttempt() {
            return passwordAttempt == password;
        }
	}
}
