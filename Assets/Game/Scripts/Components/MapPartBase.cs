using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.MapStystem.Base
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
        Opstcle,
        Wall,
    }
}
