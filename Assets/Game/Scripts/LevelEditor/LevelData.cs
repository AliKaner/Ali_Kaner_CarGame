using Game.MapSystem.Base;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.LevelSystem
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "Level Datas/New Level", order = 1)]
    public class LevelData : ScriptableObject
    {
        public List<MapPartData> MapPartDatas;
    }

    [Serializable]
    public class MapPartData
    {
        public Vector3 Position;
        public Vector3 Rotation;
        public Vector3 Scale;
        public MapPartType mapPartType;
    }
}