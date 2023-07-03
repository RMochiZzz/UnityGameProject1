using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyAttribute : MonoBehaviour
    {
        private int instanceCounter;
        private int dropCoinInstanceCounter;
        private int destroyCounter;

        public int InstanceCounter { get => instanceCounter; set => instanceCounter = value; }
        public int DestroyCounter { get => destroyCounter; set => destroyCounter = value; }
        public int DropCoinInstanceCounter { get => dropCoinInstanceCounter; set => dropCoinInstanceCounter = value; }

        public int CurrentEnemyNum
        { 
            get => InstanceCounter - DestroyCounter;
        }

        private void Start()
        {
            Init();
        }
        private void OnEnable()
        {
            Init();
        }

        private void Init()
        {
            InstanceCounter = 0;
            DestroyCounter = 0;
            DropCoinInstanceCounter = 0;
        }
    }
}