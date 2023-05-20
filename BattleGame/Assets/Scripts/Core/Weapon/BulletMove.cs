using UnityEngine;

namespace Core.Weapon
{

    public class BulletMove : MonoBehaviour
    {

        private void FixedUpdate()
        {

            transform.Translate(Vector2.right * BulletAttribute.bulletSpeed * Time.deltaTime);

        }

    }
}
