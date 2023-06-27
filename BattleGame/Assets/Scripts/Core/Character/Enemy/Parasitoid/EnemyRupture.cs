using UnityEngine;
using System.Collections;

namespace Core.Character.Enemy.Parasitoid
{
    public class EnemyRupture : MonoBehaviour
    {
        private float gradationTime = 1;
        private Vector3 spornPosition;
        private GameObject obj;

        public void Rupture(GameObject ruptureObj, GameObject baseObj, Transform container)
        {
            GetPosition(baseObj);

            Instantiate(ruptureObj, container);

            StartCoroutine(RuptureGradation(obj));
        }

        private void GetPosition(GameObject baseObj)
        {
            spornPosition = baseObj.transform.position;
        }

        private void Instantiate(GameObject ruptureObj, Transform container)
        {
            obj = Instantiate(ruptureObj, spornPosition, Quaternion.identity, container);
        }

        private IEnumerator RuptureGradation(GameObject obj)
        {
            float t = 0f;
            Color startColor = Color.clear;
            Color endColor = Color.white;

            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();

            while (t < 1f)
            {
                t += Time.unscaledDeltaTime / gradationTime;
                spriteRenderer.color = Color.Lerp(startColor, endColor, t);
                yield return null;
            }

            RuptureObjDestroy(obj);
        }
        private void RuptureObjDestroy(GameObject obj)
        {
            Destroy(obj);
        }
    }
}
