using UnityEngine;
using System.Collections;

namespace Core.Weapon
{

    public class CoinCollector : MonoBehaviour
    {
        private LevelupManager levelupManager;

        private void Start () 
        {
            StartCoroutine(Init());
        }

        private IEnumerator Init () 
        {
            levelupManager = FindObjectOfType<LevelupManager>();
            if (levelupManager == null)
            {
                GameObject levelupManagerObj = new GameObject("LevelupManager");
                levelupManager = levelupManagerObj.AddComponent<LevelupManager>();
            }

            yield return null;

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
