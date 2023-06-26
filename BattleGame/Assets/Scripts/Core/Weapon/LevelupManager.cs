using Interface.Interfaces;
using UnityEngine;

namespace Core.Weapon
{
    public class LevelupManager : MonoBehaviour
    {
        [SerializeField] private int levelTwoNum;
        [SerializeField] private int levelThreeNum;

        private IBulletFactory attackOne;
        private IBulletFactory attackTwo;
        private IBulletFactory attackThree;

        private int coinsNum;

        public int CoinsNum
        {
            get { return coinsNum; }
            set 
            {
                coinsNum = value;

                if (coinsNum == 0)
                {
                    attackOne.Starter();
                }
                
                if (coinsNum == levelTwoNum)
                {
                    attackOne.Execution = false;
                    attackTwo.Starter();
                }
                
                if (coinsNum == levelThreeNum)
                {
                    attackTwo.Execution = false;
                    attackThree.Starter();
                }
            }
        }

        private void Start()
        {
            Reference();
        }

        private void Reference()
        { 
            attackOne = new AttackOne();
            attackTwo = new AttackTwo();
            attackThree = new AttackThree();
        }
    }
}
