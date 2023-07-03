using UnityEngine;
using Core.Weapon;

namespace Core.Item
{

    public class CoinCollector : MonoBehaviour
    {
        [SerializeField] private GameObject WeaponManager;
        private LevelupManager levelupManager;

        private void Start () 
        {
            Reference();
        }

        private void Reference()
        {
            levelupManager = WeaponManager.GetComponent<LevelupManager>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("DropCoin"))
            {

                Destroy(collision.gameObject);
                levelupManager.CoinsNum += 1;

            }
        }
    }
}
