using UnityEngine;

namespace Collectibles
{
    public abstract class Collectible : MonoBehaviour
    {
        public int Value { get; protected set; }

        private void Start()
        {
            SetValue();
        }

        protected abstract void SetValue();
    }
}