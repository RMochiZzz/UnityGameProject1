using System;
using UnityEngine;
using TMPro;
using SceneManagement.Battle;

namespace SceneManagement.UI
{
    public class TimeText : MonoBehaviour
    {
        private TextMeshProUGUI timerText;
        private BattleSceneStatus battleSceneStatus;

        private void Start()
        {
            Reference();
        }

        private void Update()
        {
            UpdateBattleTimeUI();
        }

        private void UpdateBattleTimeUI()
        {
            TimeSpan span = new TimeSpan(0, 0, (int)battleSceneStatus.RemainingTime);
            timerText.text = span.ToString(@"mm\:ss");
        }

        private void Reference()
        {
            timerText = GetComponent<TextMeshProUGUI>();
            battleSceneStatus = GameObject.Find("BattleSceneManager").GetComponent<BattleSceneStatus>();
        }

        
    }
}
