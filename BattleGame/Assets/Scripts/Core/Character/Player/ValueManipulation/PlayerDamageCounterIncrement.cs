using Core.Character.Player;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Item.ValueManipulator
{
    public class PlayerDamageCounterIncrement : IIncrement
    {

        private PlayerAttribute playerAttribute;

        public void Increment()
        {
            playerAttribute = GameObject.Find("Player").GetComponent<PlayerAttribute>();
            playerAttribute.PlayerDamage++;
        }
    }
}
