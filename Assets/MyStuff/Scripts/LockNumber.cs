namespace MyStuff {

	using UnityEngine;
	using UnityEngine.UI;
    using VRTK;

	public class LockNumber : MonoBehaviour {

		public int number = -1;
		public Text numberText;
		public Lock myLock;

		// Use this for initialization
		void Start () {
			VRTK_Logger.Info("LockNumber Start");
			numberText.text = string.Format("{0}", number);
		}

		public void Activate() {
            VRTK_Logger.Info("LockNumber activated: " + number);
			myLock.AddNumber(number);
        }
	}
}
