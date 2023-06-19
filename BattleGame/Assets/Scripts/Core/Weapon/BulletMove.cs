using UnityEngine;

namespace Core.Weapon
{
    public class BulletMove : MonoBehaviour
    {
        private void FixedUpdate()
        {

            transform.Translate(Vector2.up * BulletAttribute.bulletSpeed * Time.deltaTime);

        }
    }
}
