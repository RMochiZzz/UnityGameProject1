using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Core.Movement
{
    public class MapLooper : MonoBehaviour
    {
        [SerializeField] private float fieldWidth;
        [SerializeField] private float fieldHeight;
        [SerializeField] GameObject player;
        [SerializeField] GameObject enemiesContainer;
        [SerializeField] GameObject bulletsContainer;
        [SerializeField] GameObject coinsContainer;

        private Vector3 playerPositionBefore;
        private Vector3 playerPositionAfter;

        private float leftBorder;
        private float rightBorder;
        private float upBorder;
        private float downBorder;

        private bool processObjectsThisFrame;
        private bool isOutOfBounds;

        private void Start()
        {
            Init();
        }

        private void Update()
        {
            CheckBoundsAndSetProcessFlag();
            ProcessObjects();
        }

        private void CheckBoundsAndSetProcessFlag()
        {
            playerPositionBefore = transform.position;
            playerPositionAfter = transform.position;
            CheckBorders();

            if (isOutOfBounds)
            {
                processObjectsThisFrame = true;
            }
        }

        private void ProcessObjects()
        {
            if (processObjectsThisFrame)
            {
                GameObject[] gameObjects = GetObjectsToProcess();

                foreach (var item in gameObjects)
                {
                    Vector3 offset = item.transform.position - playerPositionBefore;
                    Vector3 newPosition = playerPositionAfter + offset;

                    item.transform.position = newPosition;
                }

                processObjectsThisFrame = false;
            }
        }

        private GameObject[] GetObjectsToProcess()
        {
            List<GameObject> objectList = new List<GameObject>();

            objectList.Add(player);

            foreach (Transform child in enemiesContainer.transform)
            {
                objectList.Add(child.gameObject);
            }

            foreach (Transform child in bulletsContainer.transform)
            {
                objectList.Add(child.gameObject);
            }

            foreach (Transform child in coinsContainer.transform)
            {
                objectList.Add(child.gameObject);
            }

            return objectList.ToArray();
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

        private void Init()
        {
            leftBorder = transform.position.x - fieldWidth / 2f;
            rightBorder = transform.position.x + fieldWidth / 2f;
            upBorder = transform.position.y + fieldHeight / 2f;
            downBorder = transform.position.y - fieldHeight / 2f;

            isOutOfBounds = false;
        }
    }
}
