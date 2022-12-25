using Assets.Game.Scripts.Utils;
using Game.LevelSystem;
using Game.MapStystem.Base;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Managers
{
    public class AssetManager : GenericSingleton<AssetManager>
    {
        private const string LEVEL_PACK = "Levels/Level";
        private const string MAP_PACK = "PlatformPrefabs";

        private List<MapPartBase> _MapPartBases;

        public Material GroundMaterial;
        public Material CarMaterial;
        public Material WallMaterial;

        public void LoadPlatformPrefabs()
        {
            _MapPartBases = Resources.LoadAll<MapPartBase>(MAP_PACK).ToList();
        }

        public MapPartBase GetPlatform(MapPartType mapPartType)
        {
            return _MapPartBases?.FirstOrDefault(x => x.mapPartType == mapPartType);
        }

        public LevelData LoadLevel(int levelindex)
        {
            return Resources.Load<LevelData>(LEVEL_PACK + levelindex);
        }
    }
}