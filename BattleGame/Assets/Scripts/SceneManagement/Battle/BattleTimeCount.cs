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
            GetReference();

            StartCoroutine(ElapsedTimeRoutine());
        }

        private void OnEnable()
        {
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

        private void GetReference()
        {
            battleSceneStatus = GameObject.Find("BattleSceneManager").GetComponent<BattleSceneStatus>();
            playerAttribute = GameObject.Find("Player").GetComponent<PlayerAttribute>();
        }
    }
}
