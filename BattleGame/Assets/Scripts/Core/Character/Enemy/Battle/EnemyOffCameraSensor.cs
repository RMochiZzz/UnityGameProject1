using UnityEngine;

namespace Core.Character.Enemy.Battle
{
    public class EnemyOffCameraSensor : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;
        [SerializeField] private float checkTimer;

        private EnemyInstanceAttribute enemyInstance;
        private EnemyDestroyNoDrop enemyDestroyNoDrop;

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
                enemyDestroyNoDrop.Starter();
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

            enemyDestroyNoDrop = GetComponent<EnemyDestroyNoDrop>();

            enemyInstance = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceAttribute>();

        }
    }
}
