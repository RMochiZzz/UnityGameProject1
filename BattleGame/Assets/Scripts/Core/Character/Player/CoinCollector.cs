using UnityEngine;

namespace Core.Weapon
{

    public class CoinCollector : MonoBehaviour
    {
        private LevelupManager levelupManager;

        private void Start () 
        {
            levelupManager = FindObjectOfType<LevelupManager>();
            if (levelupManager == null)
            {
                GameObject levelupManagerObj = new GameObject("LevelupManager");
                levelupManager = levelupManagerObj.AddComponent<LevelupManager>();
            }

            levelupManager.CoinsNum = 0;
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
