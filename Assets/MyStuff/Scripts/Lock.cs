namespace MyStuff {

	using UnityEngine;
	using UnityEngine.UI;
    using VRTK;
    using System.Collections.Generic;

	public class Lock : MonoBehaviour {

		public List<int> passwordAttempt = new List<int>();
		public List<int> password = new List<int>();
		public Text displayText;

		// Use this for initialization
		void Start () {
			VRTK_Logger.Info("LockNumber Start");
			UpdateDisplay();
		}

		public void AddNumber(int num) {
			passwordAttempt.Add(num);
			UpdateDisplay();
			
			string log = "";
			foreach (int i in passwordAttempt) {
				log += i + " ";
			}
			VRTK_Logger.Info(log);
		}

		public void UpdateDisplay() {
			if (displayText != null) {
				string pwdAttemptStr = "";
				foreach (int i in passwordAttempt) {
					pwdAttemptStr += i + " ";
				}	
				displayText.text = pwdAttemptStr;
			}
		}

		public void ClearDisplay() {
			passwordAttempt.Clear();
			UpdateDisplay();
		}

		public bool Submit() {
			if (passwordAttempt.Count != password.Count) {
				ClearDisplay();
				return false;
			}

			bool isAttemptCorrect = true;
			for (int i = 0; i < password.Count; i++) {
				if (password[i] != passwordAttempt[i]) {
					isAttemptCorrect = false;
					break;
				}
			}
			VRTK_Logger.Info(string.Format("Lock.Submit {0}", isAttemptCorrect));
			if (!isAttemptCorrect) ClearDisplay();
			return isAttemptCorrect;
		}
		
	}
}
