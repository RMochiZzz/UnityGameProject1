using Interface.Interfaces;
using System.Collections;
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

                if (coinsNum == levelOneNum)
                {
                    attackTwo.Execution = false;
                    attackThree.Execution = false;
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
            Init();
        }

        private void OnEnable()
        {
            StartCoroutine(Init());
        }

        private IEnumerator Init()
        {
            yield return null;

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
