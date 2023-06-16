using UnityEngine;
using System.Collections;

namespace Core.Character.Enemy
{
    public class EnemyRupture : MonoBehaviour
    {
        public void Rupture(GameObject ruptureObj)
        {
            Vector3 spornPosition = gameObject.transform.position;

            GameObject obj = Instantiate(ruptureObj, spornPosition, Quaternion.identity);
            StartCoroutine(DestroyAfterOneFrame(obj));
        }

        private IEnumerator DestroyAfterOneFrame(GameObject obj)
        {
            yield return new WaitForSeconds(1);
            Destroy(obj);
        }
    }
}
