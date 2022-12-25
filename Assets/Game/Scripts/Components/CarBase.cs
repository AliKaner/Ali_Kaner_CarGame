using System;
using System.Collections.Generic;
using UnityEngine;
using Game.LevelSystem.Level;
using Game.Managers;

namespace Game.Car.Base
{
    public class CarBase : MonoBehaviour
    {
        public bool isGameStarted;

        [SerializeField]
        private float speed;
        private List<Transform> recordedPath = new List<Transform>();
        private int currentTransformIndex = 0;
        private LevelManager levelManager;
        private EffectManager effectManager;

        private void Awake()
        {
            levelManager = FindObjectOfType<LevelManager>();
        }

        private void MoveForward()
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        public void Initialize()
        {
            isGameStarted = false;
        }

        public void StartGame()
        {
            isGameStarted = true;
        }

        private void Update()
        {
            if (!isGameStarted) return;
            MoveForward();
        }

        private void OnCollisionEnter(Collision collision)
        {
            switch (collision.collider.tag)
            {
                case "Wall":
                case "Car":
                    StartCoroutine(effectManager.Shake(1f,1f));
                    levelManager.ResetLevel();
                    break;

                case "Finish":
                    levelManager.NextRound();
                    break;
            }
        }

        private void RecordMovement()
        {
            recordedPath.Add(transform);
        }

        public Transform GetTransform()
        {
            return transform;
        }

        public void PlayRecord(Transform transform)
        {
            transform = recordedPath[currentTransformIndex];
        }

        internal void PlayRecord()
        {
            throw new NotImplementedException();
        }
    }
}