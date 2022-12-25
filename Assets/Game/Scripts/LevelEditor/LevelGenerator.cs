using Game.Car.Base;
using Game.Managers;
using UnityEngine;
using Game.LevelSystem.Pool;

namespace Game.LevelSystem
{
    public class LevelGenerator : MonoBehaviour
    {
        private CarBase _car;
        private PoolManager _poolManager;
        private int _levelIndex;
        private Vector3 _carStartPosition;

        public void GenerateLevel()
        {
            var levelData = AssetManager.Instance.LoadLevel(_levelIndex);
            if (levelData == null)
            {
                _levelIndex = 1;
                levelData = AssetManager.Instance.LoadLevel(_levelIndex);
            }

            var mapPartList = levelData.MapPartDatas;
            foreach (var mapPartData in mapPartList)
            {
                var platform = _poolManager.GetAvailablePart(mapPartData.mapPartType);
                platform.transform.position = mapPartData.Position;
            }

            _car.transform.position = _carStartPosition;
        }
    }
}