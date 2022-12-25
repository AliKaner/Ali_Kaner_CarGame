using Game.Managers;
using Game.MapSystem.Base;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.LevelSystem.Pool
{
public class PoolManager : MonoBehaviour
    {
        private List<MapPartBase> _mapPartBases;

        public MapPartBase GetAvailablePart(MapPartType mapPartType)
        {
            if (_mapPartBases == null)
                _mapPartBases = new List<MapPartBase>();

            var map = _mapPartBases?.FirstOrDefault(x => !x.isActive && x.mapPartType == mapPartType);

            if (map == null)
            {
                map = AssetManager.Instance.GetPlatform(mapPartType);
                map = Instantiate(map, transform);
                map.Initialize();
                _mapPartBases?.Add(map);
            }

            map.Activate();
            return map;
        }

        public void DeactivateWholePool()
        {
            if (_mapPartBases.Count <= 0)
                return;

            foreach (var platform in _mapPartBases)
            {
                platform.Deactivate();
            }
        }
    }
}