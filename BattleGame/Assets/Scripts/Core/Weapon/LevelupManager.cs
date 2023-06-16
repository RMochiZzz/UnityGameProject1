using Core.Character.Enemy;
using UnityEngine;

namespace Core.Weapon
{
    public class LevelupManager : MonoBehaviour
    {
        [SerializeField] private int levelTwoNum;
        [SerializeField] private int levelThreeNum;
        private AttackOne attackOne;
        private int _coinsNum;
        public int coinsNum
        {
            get { return _coinsNum; }
            set 
            { 
                _coinsNum = value;
                if (_coinsNum == 0)
                {
                    attackOne.Manager();
                }
                else if (_coinsNum == levelTwoNum)
                {

                }
                else if (_coinsNum == levelThreeNum)
                {

                }
            }
        }

        private void Start()
        {
            GameObject attackOneobj = new GameObject("AttackOne");
            attackOne = attackOneobj.AddComponent<AttackOne>();
        }

    }
}
