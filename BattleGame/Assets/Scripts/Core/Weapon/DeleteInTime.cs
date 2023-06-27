using UnityEngine;

namespace Core.Weapon
{
    public class DeleteInTime : MonoBehaviour
    {
        [SerializeField] private GameObject Bullet;

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

