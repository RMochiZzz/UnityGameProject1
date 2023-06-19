using UnityEngine;

namespace Core.Weapon
{
    public class LevelupManager : MonoBehaviour
    {
        [SerializeField] private int levelTwoNum;
        [SerializeField] private int levelThreeNum;
        private AttackOne attackOne;
        private AttackTwo attackTwo;
        private AttackThree attackThree;
        private int coinsNum;
        public int CoinsNum
        {
            get { return coinsNum; }
            set 
            {
                coinsNum = value;

                if (coinsNum == 0)
                {
                    attackOne.starter();
                }
                
                if (coinsNum == levelTwoNum)
                {
                    attackOne.Execution = false;
                    attackTwo.starter();
                }
                
                if (coinsNum == levelThreeNum)
                {
                    attackTwo.Execution = false;
                    attackThree.starter();
                }
            }
        }

        private void Start()
        {
            attackOne = FindObjectOfType<AttackOne>();
            if (attackOne == null)
            {
                GameObject attackOneObj = new GameObject("AttackOne");
                attackOne = attackOneObj.AddComponent<AttackOne>();
            }

            attackTwo = FindObjectOfType<AttackTwo>();
            if (attackTwo == null)
            {
                GameObject attackTwoObj = new GameObject("AttackTwo");
                attackTwo = attackTwoObj.AddComponent<AttackTwo>();
            }

            attackThree = FindObjectOfType<AttackThree>();
            if (attackThree == null)
            {
                GameObject attackThreeObj = new GameObject("AttackThree");
                attackThree = attackThreeObj.AddComponent<AttackThree>();
            }
        }
    }
}
