using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyInstanceStatus : MonoBehaviour
    {
        [SerializeField] private Transform container;
        [SerializeField] private int instanceCounter;
        [SerializeField] private int instanceMax;
        private int dropCoinInstanceCounter;

        public Transform Container { get => container; set => container = value; }
        public int InstanceCounter { get => instanceCounter; set => instanceCounter = value; }
        public int InstanceMax { get => instanceMax; set => instanceMax = value; }
        public int DropCoinInstanceCounter { get => dropCoinInstanceCounter; set => dropCoinInstanceCounter = value; }

    }
}
