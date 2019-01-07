namespace MyStuff {

	using UnityEngine;
	using UnityEngine.UI;
    using VRTK;
	using VRTK.Controllables;
    using VRTK.Controllables.PhysicsBased;

	public class SpinLock_Reactor : MonoBehaviour {
   		public VRTK_BaseControllable spinControl;
        public VRTK_BaseControllable doorControl;
        public Lock2_Data lockData;

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
                doorControl.enabled = true;
                spinControl.enabled = false;
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
