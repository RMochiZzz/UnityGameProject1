using Core.Character.Enemy;
using Core.Character.Player;
using SceneManagement.Battle;
using UnityEngine;

namespace SceneManagement.Result
{
    public class ResultDataGatherer : MonoBehaviour
    {
        private ResultAttribute resultAttribute;
        private EnemyAttribute enemyAttribute;
        private BattleSceneStatus battleSceneStatus;
        private PlayerAttribute playerAttribute;

        private void Starter()
        {
            GetReference();
            CopyData();
        }

        private void CopyData()
        {
            resultAttribute.KillCount = enemyAttribute.DestroyCounter;
            resultAttribute.PlayerStamina = playerAttribute.PlayerStamina;
            resultAttribute.Time = battleSceneStatus.RemainingTime;
        }

        private void GetReference() 
        {
            resultAttribute = new ResultAttribute();
            enemyAttribute = new EnemyAttribute();
            battleSceneStatus = FindObjectOfType<BattleSceneStatus>();
            playerAttribute = FindObjectOfType<PlayerAttribute>();
        }
    }
}
