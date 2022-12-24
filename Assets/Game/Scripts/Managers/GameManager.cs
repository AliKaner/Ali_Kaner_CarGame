using UnityEngine;
using System;
using Game.LevelSystem;

namespace Game.Managers
{
    public class GameManager : MonoBehaviour
    {
        private LevelGenerator _levelGenerator;
        private CarBase _car;

        private void OnInstaller(LevelGenerator levelGenerator, CarBase carBase)
        {
            _levelGenerator = levelGenerator;
            _car = carBase;

            AssetManager.Instance.LoadPlatformPrefabs();

            _car.Initialize();
        }

        private void Start()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            _levelGenerator.GenerateLevel();
        }
    }
}