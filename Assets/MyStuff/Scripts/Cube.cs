namespace MyStuff
{
    using UnityEngine;
    using UnityEngine.UI;
    using VRTK;

    public class Cube : MonoBehaviour
    {
        public int number = -1;

        public void Activate() {
            VRTK_Logger.Info("Cube activated: " + number);
        }

        protected Color originalColor = Color.clear;

        public virtual void Highlight()
        {
  
        }

        public virtual void Unhighlight()
        {
   
        }
    }
}