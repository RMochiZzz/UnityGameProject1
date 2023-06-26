using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyAttribute
    {
        private Transform container;
        private int instanceMax;
        private int instanceCounter;
        private int dropCoinInstanceCounter;
        private int destroyCounter;

        public Transform Container { get => container; set => container = value; }
        public int InstanceMax { get => instanceMax; set => instanceMax = value; }
        public int InstanceCounter { get => instanceCounter; set => instanceCounter = value; }
        public int DestroyCounter { get => destroyCounter; set => destroyCounter = value; }
        public int DropCoinInstanceCounter { get => dropCoinInstanceCounter; set => dropCoinInstanceCounter = value; }


    }
}