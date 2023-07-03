using Core.Character.Enemy;
using Core.Character.Player;
using SceneManagement.Battle;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace SceneManagement.Result
{
    public class ResultScoreText : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject battlesceneManager;
        [SerializeField] private GameObject enemyManager;

        private TextMeshProUGUI textComp;

        private EnemyAttribute enemyAttribute;
        private BattleSceneStatus battleSceneStatus;
        private PlayerAttribute playerAttribute;

        public void Start()
        {
            GetReference();

            StartCoroutine(ViewScores());
        }

        private IEnumerator ViewScores()
        {
            yield return null;

            textComp.text = "Kill Count: " + enemyAttribute.DestroyCounter.ToString() + "\n" +
                    "Remaining Time: " + TimeSpan.FromSeconds((int)battleSceneStatus.RemainingTime).ToString() + "\n" +
                    "Player Stamina: " + playerAttribute.CurrentPlayerStamina.ToString();

        }

        private void GetReference()
        {
            textComp = GetComponent<TextMeshProUGUI>();

            enemyAttribute = enemyManager.GetComponent<EnemyAttribute>();
            battleSceneStatus = battlesceneManager.GetComponent<BattleSceneStatus>();
            playerAttribute = player.GetComponent<PlayerAttribute>();
        }
    }
}
