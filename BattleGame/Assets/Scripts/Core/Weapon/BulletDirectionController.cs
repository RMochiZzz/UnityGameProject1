using UnityEngine;

namespace Core.Weapon
{
    public class BulletDirectionController : MonoBehaviour
    {

        public static float randamAngle = Random.Range(0f, 360f);
        public static Quaternion bulletFireDirection = Quaternion.Euler(randamAngle, randamAngle, 0);

        void Update()
        {

            
        }
    }
}
