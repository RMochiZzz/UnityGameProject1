using UnityEngine;

namespace SceneManagement.Battle
{
    public class BattleTimeCountDown : MonoBehaviour
    {
        private BattleSceneStatus battleSceneStatus;

        private void Start()
        {
            battleSceneStatus = GameObject.Find("SceneManager").GetComponent<BattleSceneStatus>();
        }

        private void Update()
        {
            battleSceneStatus.BattleTime -= Time.deltaTime;
        }
    }
}
