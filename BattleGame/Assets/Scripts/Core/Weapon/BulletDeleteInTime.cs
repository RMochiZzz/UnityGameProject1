using UnityEngine;


namespace Core.Weapon
{
    public class BulletDeleteInTime : MonoBehaviour
    {

        public GameObject Bullet;

        void Start()
        {

            Invoke("DestroyBullet", BulletAttribute.bulletDeleteTime);

        }

        void DestroyBullet()
        { 
        
            Destroy(Bullet);
        
        }
    }
}

