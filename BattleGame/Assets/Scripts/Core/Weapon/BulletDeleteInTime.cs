using UnityEngine;


namespace Core.Weapon
{
    public class BulletDeleteInTime : MonoBehaviour
    {

        public GameObject Bullet;
        public float bulletDeleteTime = 5f;

        void Start()
        {

            Invoke("DestroyBullet", bulletDeleteTime);

        }

        void DestroyBullet()
        { 
        
            Destroy(Bullet);
        
        }
    }
}

