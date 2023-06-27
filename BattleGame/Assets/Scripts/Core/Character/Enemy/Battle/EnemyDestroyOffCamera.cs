using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.Battle
{
    public class EnemyDestroyOffCamera : MonoBehaviour
    {
        public void Starter()
        {
            DestroyEnemy();
        }

        private void DestroyEnemy()
        {
            Destroy(gameObject);
        }
    }
}
