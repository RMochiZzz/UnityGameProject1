using UnityEngine;
using Core.Character.Enemy;

namespace Core.Movement
{
    public class MoveForward : MonoBehaviour
    {
        void FixedUpdate()
        {

            Vector2 forwardDirection = transform.up;

            Vector2 move = forwardDirection * EnemyAttribute.enemySpeed * Time.deltaTime;

            transform.position += new Vector3(move.x, move.y, 0f);

        }
    }

}