namespace MyStuff
{
    using UnityEngine;
	using VRTK;

    public class LockSelector : MonoBehaviour
    {
        public VRTK_DestinationMarker pointer;

        protected virtual void OnEnable()
        {
            pointer = (pointer == null ? GetComponent<VRTK_DestinationMarker>() : pointer);

            if (pointer != null)
            {
                pointer.DestinationMarkerSet += DestinationMarkerSet;
            }
            else
            {
                VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTKExample_OptionTileSelector", "VRTK_DestinationMarker", "the Controller Alias"));
            }
        }

        protected virtual void OnDisable()
        {
            if (pointer != null)
            {
                pointer.DestinationMarkerSet -= DestinationMarkerSet;
            }
        }

        protected virtual void DestinationMarkerSet(object sender, DestinationMarkerEventArgs e)
        {
            if (e.target != null)
            {
                LockNumber lockNumber = e.target.GetComponent<LockNumber>();
                if (lockNumber != null)
                {
                    lockNumber.Activate();
                }

                LockSubmit lockSubmit = e.target.GetComponent<LockSubmit>();
                if (lockSubmit != null)
                {
                    lockSubmit.Activate();
                }
            }
        }
    }
}