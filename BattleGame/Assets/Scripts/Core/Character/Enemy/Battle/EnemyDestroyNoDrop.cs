using UnityEngine;

namespace Core.Character.Enemy.Battle
{
    public class EnemyDestroyNoDrop : MonoBehaviour
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