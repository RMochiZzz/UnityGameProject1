using Core.Character.Player;
using UnityEngine;
using System.Collections;

namespace SceneManagement.Battle
{
    public class BattleTimeCountDown : MonoBehaviour
    {
        private BattleSceneStatus battleSceneStatus;
        private PlayerAttribute playerAttribute;

        private void Start()
        {
            battleSceneStatus = GameObject.Find("SceneManager").GetComponent<BattleSceneStatus>();
            playerAttribute = GameObject.Find("Player").GetComponent<PlayerAttribute>();

            StartCoroutine(CountDownRoutine());
        }

        private IEnumerator CountDownRoutine()
        {
            while (playerAttribute.PlayerStamina != 0)
            {
                battleSceneStatus.BattleTime -= Time.deltaTime;
                yield return null;
            }
        }
    }
}
