using UnityEngine;
using Core.Character.Player;

namespace Core.Weapon
{
    public class WeaponLevelupManager : MonoBehaviour
    {

        private void Update()
        {
            if (PlayerAttribute.numberOfCoins <= 10) 
            {
                LevelOne();
            }
            else if (PlayerAttribute.numberOfCoins >= 11)
            {
                LevelTwo();
            }
            else if (PlayerAttribute.numberOfCoins >= 100)
            {
                LevelThree();
            }
        }

        public void LevelOne()
        {
            BulletAttribute.levelOneIsActive = true;
        }
        public void LevelTwo()
        {
            BulletAttribute.levelOneIsActive = false;
            BulletAttribute.levelTwoIsActive = true;
        }
        public void LevelThree()
        {
            BulletAttribute.levelTwoIsActive = false;
            BulletAttribute.levelThreeIsActive = true;
        }
    }
}
