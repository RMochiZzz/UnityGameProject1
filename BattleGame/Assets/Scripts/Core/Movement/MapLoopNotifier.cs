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
        private Vector3 playerPositionBefore;
        private Vector3 playerPositionAfter;
        public delegate void myEventHandler(Vector3 vector3, Vector3 vector3B);
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
            playerPositionBefore = transform.position;
            playerPositionAfter = transform.position;
            CheckBorders();

            if (isOutOfBounds)
            {
                isOutOfBounds = false;
                transform.position = playerPositionAfter;
                MyEvent?.Invoke(playerPositionBefore, playerPositionAfter);
            }
        }

        private void CheckBorders()
        {
            if (playerPositionAfter.x < leftBorder)
            {
                playerPositionAfter.x = rightBorder;
                isOutOfBounds = true;
            }

            if (playerPositionAfter.x > rightBorder)
            {
                playerPositionAfter.x = leftBorder;
                isOutOfBounds = true;
            }

            if (playerPositionAfter.y > upBorder)
            {
                playerPositionAfter.y = downBorder;
                isOutOfBounds = true;
            }

            if (playerPositionAfter.y < downBorder)
            {
                playerPositionAfter.y = upBorder;
                isOutOfBounds = true;
            }
        }
    }
}
