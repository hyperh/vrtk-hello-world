namespace MyStuff {

	using UnityEngine;
	using UnityEngine.UI;
    using VRTK;

	public class LockSubmit : MonoBehaviour {
	    public Lock myLock;
        public void Activate() {
            VRTK_Logger.Info("LockSubmit activated");
			myLock.Submit();
        }
	}
}
