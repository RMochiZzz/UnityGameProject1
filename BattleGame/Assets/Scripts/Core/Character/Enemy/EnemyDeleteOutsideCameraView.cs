using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDeleteOutsideCameraView : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;
        private float checkTimer = 1f;

        private void Start()
        {
            InvokeRepeating(nameof(CheckCameraView), checkTimer, checkTimer);
        }

        private void CheckCameraView()
        {
            if (IsInCameraView()) Destroy(gameObject);
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
    }
}
