using Core.Character.Player;
using UnityEngine;
using System.Collections;

namespace SceneManagement.Battle
{
    public class BattleTimeCount : MonoBehaviour
    {
        private BattleSceneStatus battleSceneStatus;
        private PlayerAttribute playerAttribute;

        private void Start()
        {
            battleSceneStatus = GameObject.Find("SceneManager").GetComponent<BattleSceneStatus>();
            playerAttribute = GameObject.Find("Player").GetComponent<PlayerAttribute>();

            StartCoroutine(ElapsedTimeRoutine());
        }

        private IEnumerator ElapsedTimeRoutine()
        {
            while (playerAttribute.PlayerStamina != 0)
            {
                battleSceneStatus.CurrentElapsedTime += Time.deltaTime;
                yield return null;
            }
        }
    }
}
