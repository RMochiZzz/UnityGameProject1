using UnityEngine;

namespace Core.Character.Player
{

    public class CoinCollector : MonoBehaviour
    {
        public GameObject dropCoin;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("DropCoin"))
            {

                Destroy(collision.gameObject);
                PlayerAttribute.numberOfCoins++;

            }
        }
 
    }
}

