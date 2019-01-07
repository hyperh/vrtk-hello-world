namespace MyStuff {

	using UnityEngine;
	using UnityEngine.UI;
    using VRTK;
	using VRTK.Controllables;

	public class SpinLock_Reactor : MonoBehaviour {
   		public VRTK_BaseControllable spinControl;
        public VRTK_BaseControllable doorControl;
        public Lock2_Data lockData;
        public AudioSource openDoorSound;

        protected virtual void OnEnable()
        {
            spinControl = (spinControl == null ? GetComponent<VRTK_BaseControllable>() : spinControl);
            spinControl.ValueChanged += ValueChanged;
            spinControl.MaxLimitReached += MaxLimitReached;
            spinControl.MinLimitReached += MinLimitReached;
        }

        protected virtual void ValueChanged(object sender, ControllableEventArgs e)
        {
            lockData.UpdateAttempt(e.value.ToString());
            bool isAttemptCorrect = lockData.CheckAttempt();
            if (isAttemptCorrect) {
                // Can't seem to interact with spinControl properly when doorControl is enabled. Need to keep doorControl disabled before unlocking.
                doorControl.enabled = true;
                spinControl.enabled = false;
                openDoorSound.Play();
            }
            VRTK_Logger.Info(string.Format("Lock2_Reactor.ValueChanged {0}", e.value.ToString()));
        }

        protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
        {

        }

        protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
        {

        }
	}
}
