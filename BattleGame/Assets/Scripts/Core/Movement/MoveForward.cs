using Core.Character.Enemy;
using UnityEngine;

namespace Core.Movement
{
    public class MoveForward : MonoBehaviour
    {
        private EnemyStatus enemyStatus;

        private void Awake()
        {
            Reference();
        }
        private void Update()
        {

            Vector2 forwardDirection = transform.up;

            Vector2 move = forwardDirection * enemyStatus.EnemySpeed * Time.deltaTime;

            transform.position += new Vector3(move.x, move.y, 0f);

        }

        private void Reference() 
        {
            enemyStatus = GetComponentInParent<EnemyStatus>();
        }
    }
}
