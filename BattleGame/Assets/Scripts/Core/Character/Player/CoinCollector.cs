using UnityEngine;

namespace Core.Weapon
{

    public class CoinCollector : MonoBehaviour
    {
        private LevelupManager levelupManager;

        private void Start () 
        { 
            levelupManager = GetComponent<LevelupManager>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.gameObject.CompareTag("DropCoin"))
            {

                Destroy(collision.gameObject);
                levelupManager.coinsNum += 1;

            }
        }
    }
}

