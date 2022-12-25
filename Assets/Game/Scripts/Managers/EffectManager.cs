using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Managers.Effect
{
    public class EffectManager : MonoBehaviour
    {
        private Transform cam;

        private void Awake()
        {
            cam = Camera.main.transform;
        }

        public IEnumerator Shake(float duration, float magnitude)
        {
            Vector3 orignalPosition = cam.position;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                float x = Random.Range(-1f, 1f) * magnitude;
                float y = Random.Range(-1f, 1f) * magnitude;

                cam.position = new Vector3(x, y, -10f);
                elapsed += Time.deltaTime;
                yield return 0;
            }

            cam.position = orignalPosition;
        }
    }
}