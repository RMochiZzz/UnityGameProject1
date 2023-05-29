using UnityEngine;
using Core.Character.Player;

namespace Core.Movement
{
    public class MapLoopNotifier : MonoBehaviour
    {
        public float fieldWidth = 30f;
        public float fieldHeight = 30f;
        private float leftBorder;
        private float rightBorder;
        private float upBorder;
        private float downBorder;
        private bool isOutOfBounds = false;
        public delegate void myEventHandler(Vector3 vector3);
        public static event myEventHandler MyEvent;

        private void Start()
        {
            leftBorder = transform.position.x - fieldWidth / 2f;
            rightBorder = transform.position.x + fieldWidth / 2f;
            upBorder = transform.position.y + fieldHeight / 2f;
            downBorder = transform.position.y - fieldHeight / 2f;
        }

        private void Update()
        {
            PlayerAttribute.playerPosition = transform.position;
            CheckBorders();
        }

        private void LateUpdate()
        {

            if (isOutOfBounds)
            {
                isOutOfBounds = false;
                transform.position = PlayerAttribute.playerPosition;
                MyEvent?.Invoke(transform.position);
            }
        }

        private void CheckBorders()
        {
            if (PlayerAttribute.playerPosition.x < leftBorder)
            {
                PlayerAttribute.playerPosition.x = rightBorder;
                isOutOfBounds = true;
            }
            else if (PlayerAttribute.playerPosition.x > rightBorder)
            {
                PlayerAttribute.playerPosition.x = leftBorder;
                isOutOfBounds = true;
            }
            else if (PlayerAttribute.playerPosition.y > upBorder)
            {
                PlayerAttribute.playerPosition.y = downBorder;
                isOutOfBounds = true;
            }
            else if (PlayerAttribute.playerPosition.y < downBorder)
            {
                PlayerAttribute.playerPosition.y = upBorder;
                isOutOfBounds = true;
            }
        }
    }
}
