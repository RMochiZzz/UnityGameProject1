using UnityEngine;

namespace Core.Movement
{
    public class MapLoopNotifier : MonoBehaviour
    {
        [SerializeField] private float fieldWidth;
        [SerializeField] private float fieldHeight;
        private float leftBorder;
        private float rightBorder;
        private float upBorder;
        private float downBorder;
        private bool isOutOfBounds;
        private Vector3 playerPosition;
        public delegate void myEventHandler(Vector3 vector3);
        public event myEventHandler MyEvent;

        private void Start()
        {
            leftBorder = transform.position.x - fieldWidth / 2f;
            rightBorder = transform.position.x + fieldWidth / 2f;
            upBorder = transform.position.y + fieldHeight / 2f;
            downBorder = transform.position.y - fieldHeight / 2f;

            isOutOfBounds = false;
        }

        private void Update()
        {
            playerPosition = transform.position;
            CheckBorders();

            if (isOutOfBounds)
            {
                isOutOfBounds = false;
                transform.position = playerPosition;
                MyEvent?.Invoke(playerPosition);
            }
        }

        private void CheckBorders()
        {
            if (playerPosition.x < leftBorder)
            {
                playerPosition.x = rightBorder;
                isOutOfBounds = true;
            }

            if (playerPosition.x > rightBorder)
            {
                playerPosition.x = leftBorder;
                isOutOfBounds = true;
            }

            if (playerPosition.y > upBorder)
            {
                playerPosition.y = downBorder;
                isOutOfBounds = true;
            }

            if (playerPosition.y < downBorder)
            {
                playerPosition.y = upBorder;
                isOutOfBounds = true;
            }
        }
    }
}
