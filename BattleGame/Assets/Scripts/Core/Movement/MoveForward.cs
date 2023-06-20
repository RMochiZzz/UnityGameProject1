using Core.Character.Enemy.GroupRush;
using UnityEngine;

namespace Core.Movement
{
    public class MoveForward : MonoBehaviour
    {
        private EnemyStatus enemyStatus;

        private void Start()
        {
            enemyStatus = GetComponent<EnemyStatus>();
        }
        private void Update()
        {

            Vector2 forwardDirection = transform.up;

            Vector2 move = forwardDirection * enemyStatus.EnemySpeed * Time.deltaTime;

            transform.position += new Vector3(move.x, move.y, 0f);

        }
    }

}
