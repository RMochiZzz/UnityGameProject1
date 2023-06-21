using UnityEngine;

namespace SceneManagement
{
    public class BattleSceneStatus : MonoBehaviour
    {
        [SerializeField] private float battleTime;
        public float BattleTime { get => battleTime; set => battleTime = value; }
    }
}
