using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Character.Player
{

    public class CoinCollector : MonoBehaviour
    {
        public GameObject dropCoin;

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "DropCoin")
            {

                Destroy(collision.gameObject);
                PlayerAttribute.numberOfCoins++;

            }

        }
    }
}

