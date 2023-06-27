using Core.Character.Player;
using Interface.Interfaces;

namespace Core.Character.Item.ValueManipulator
{
    public class PlayerDamageCounterIncrement : IIncrement
    {

        private PlayerAttribute playerAttribute;

        public void Increment()
        {
            playerAttribute = new PlayerAttribute();
            playerAttribute.PlayerDamage++;
        }
    }
}
