using UnityEngine;
using Core.Character.Enemy;

namespace Core.Movement
{
    public class MoveForward : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        void Update()
        {

            Vector2 forwardDirection = transform.up;

            Vector2 move = forwardDirection * moveSpeed * Time.deltaTime;

            transform.position += new Vector3(move.x, move.y, 0f);

        }
    }

}
