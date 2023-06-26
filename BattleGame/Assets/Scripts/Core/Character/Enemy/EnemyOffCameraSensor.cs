using Interface.Clients;
using Interface.Implementations;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyOffCameraSensor : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;
        private float checkTimer = 1f;
        private EnemyInstanceAttribute enemyInstance;
        private IIncrement increment;
        private EnemyDestroyIncrementHandler destroyIncrementHandler;

        private void Start()
        {
            increment = new EnemyInstanceCounterIncrement();
            destroyIncrementHandler = new EnemyDestroyIncrementHandler();

            enemyInstance = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceAttribute>();
            InvokeRepeating(nameof(CheckCameraView), checkTimer, checkTimer);
        }

        private void CheckCameraView()
        {
            if (IsInCameraView())
            {
                Destroy(gameObject);
                CounterIncrement();
            }
        }

        private bool IsInCameraView()
        {
            Vector3 viewPosition = Camera.main.WorldToViewportPoint(transform.position);

            if (viewPosition.y >= 1f) return true;
            if (viewPosition.y <= -1f) return true;
            if (viewPosition.x >= 1f) return true;
            if (viewPosition.x <= -1f) return true;
            return false;
        }

        private void CounterIncrement()
        {
            destroyIncrementHandler.DestroyIncrement(increment);
        }
    }
}
