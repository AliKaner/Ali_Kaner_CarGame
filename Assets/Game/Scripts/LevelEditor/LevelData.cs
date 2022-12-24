using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.MapStystem.Base;

namespace Game.LevelSystem
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "Level Datas/New Level", order = 1)]
    public class LevelData : ScriptableObject
    {
        public List<MapPartData> MapPartDatas;
        public List<Entrance> Entrances;
        public List<Target> Targets;
    }
    
    [Serializable]
    public class MapPartData
    {
        public Vector3 Position;
        public Vector3 Rotation;
        public Vector3 Scale;   
        public MapPartType mapPartType;
    }

    [Serializable]
    public class Entrance
    {
        public Vector3 Position;
        public int index;
    }

    [Serializable]
    public class Target
    {
        public Vector3 Position;
        public int index;
    }
}