using UnityEngine;

namespace Core.Weapon
{
    public class DeleteInTime : MonoBehaviour
    {
        public GameObject Bullet;

        void Start()
        {

            Invoke("DestroyBullet", BulletAttribute.deleteInTime);

        }

        void DestroyBullet()
        { 
        
            Destroy(Bullet);
        
        }
    }
}

