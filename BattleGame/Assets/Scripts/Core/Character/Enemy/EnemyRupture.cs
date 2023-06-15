using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyRupture : MonoBehaviour
    {
        public void Rupture(GameObject ruptureObj)
        {
            Vector3 spornPosition = gameObject.transform.position;

            Instantiate(ruptureObj, spornPosition, Quaternion.identity);


        }
    }

}
