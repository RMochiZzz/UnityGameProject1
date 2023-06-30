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

        public void Starter()
        {
            GetReference();
            CopyData();
        }

        private void CopyData()
        {
            resultAttribute.KillCountAtEnd = enemyAttribute.DestroyCounter;
            resultAttribute.PlayerStaminaAtEnd = playerAttribute.CurrentPlayerStamina;
            resultAttribute.RemainingTimeAtEnd = battleSceneStatus.RemainingTime;
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
