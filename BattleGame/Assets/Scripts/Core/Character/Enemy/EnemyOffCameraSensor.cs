using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyOffCameraSensor : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;

        private float checkTimer = 1f;

        private EnemyInstanceAttribute enemyInstance;
        private EnemyDestroy enemyDestroy;

        private void Start()
        {
            Reference();
            Repeater();
        }

        private void Repeater()
        {
            InvokeRepeating(nameof(CheckCameraView), checkTimer, checkTimer);
        }

        private void CheckCameraView()
        {
            if (IsInCameraView())
            {
                enemyDestroy.Starter();
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

        private void Reference()
        {

            enemyDestroy = GetComponent<EnemyDestroy>();

            enemyInstance = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceAttribute>();

        }
    }
}
