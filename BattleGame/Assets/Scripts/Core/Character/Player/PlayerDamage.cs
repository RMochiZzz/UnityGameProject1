using Core.Character.Item.ValueManipulator;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Player
{
    public class PlayerDamage : MonoBehaviour
    {
        private PlayerAttribute playerAttribute;
        private IIncrement playerDamageCounterIncrement;

        void Start () 
        {
            Reference();
        }

        private void Reference()
        {
            playerAttribute = GetComponent<PlayerAttribute>();
            playerDamageCounterIncrement = new PlayerDamageCounterIncrement();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (playerAttribute.CurrentPlayerStamina == 0 ||
                !collision.gameObject.CompareTag("Enemy") &&
                !collision.gameObject.CompareTag("Rupture"))
            {
                return;
            }

            playerDamageCounterIncrement.Increment();
        }
    }
}
