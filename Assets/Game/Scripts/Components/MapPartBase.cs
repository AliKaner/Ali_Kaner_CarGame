using UnityEngine;

namespace Game.MapSystem.Base
{
    public abstract class MapPartBase : MonoBehaviour
    {
        public abstract MapPartType mapPartType { get; }
        public bool isActive;

        public virtual void Intialize()
        {
            isActive = true;
        }

        public void Activate()
        {
            isActive = true;
            gameObject.SetActive(true);
        }

        public void Deactivate()
        {
            isActive = false;
            gameObject.SetActive(false);
        }

        internal abstract void Initialize();
    }

    public enum MapPartType
    {
        ENTRANCE,
        WALL,
        TARGET
    }
}