using Interface.Interfaces;
using UnityEngine;

namespace Core.Weapon
{
    public class LevelupManager : MonoBehaviour
    {
        private const int levelOneNum = 0;
        private const int levelTwoNum = 10;
        private const int levelThreeNum = 50;

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

                switch (coinsNum)
                {
                    case levelOneNum:
                        attackTwo.Execution = false;
                        attackThree.Execution = false;
                        attackOne.Starter();
                        break;

                    case levelTwoNum:
                        attackOne.Execution = false;
                        attackTwo.Starter();
                        break;

                    case levelThreeNum:
                        attackTwo.Execution = false;
                        attackThree.Starter();
                        break;
                }
            }
        }

        private void Start()
        {
            Reference();
        }

        private void OnEnable()
        {
            CoinsNum = 0;
        }

        private void Reference()
        { 
            attackOne = GetComponent<AttackOne>();
            attackTwo = GetComponent<AttackTwo>();
            attackThree = GetComponent<AttackThree>();
        }
    }
}
