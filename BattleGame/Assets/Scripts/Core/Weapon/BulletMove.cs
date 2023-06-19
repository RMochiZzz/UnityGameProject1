using UnityEngine;

namespace Core.Weapon
{
    public class BulletMove : MonoBehaviour
    {
        private void Update()
        {

            transform.Translate(Vector2.up * BulletAttribute.bulletSpeed * Time.deltaTime);

        }
    }
}
