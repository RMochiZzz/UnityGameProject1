using System;
using UnityEngine;
using TMPro;

namespace SceneManagement.UI
{
    public class TimeText : MonoBehaviour
    {
        private TextMeshProUGUI timerText;
        private BattleSceneStatus battleSceneStatus;

        private void Start()
        {
            timerText = GetComponent<TextMeshProUGUI>();

            battleSceneStatus = GameObject.Find("SceneManager").GetComponent<BattleSceneStatus>();
        }

        void Update()
        {
            battleSceneStatus.BattleTime -= Time.deltaTime;
            TimeSpan span = new TimeSpan(0, 0, (int)battleSceneStatus.BattleTime);
            timerText.text = span.ToString(@"mm\:ss");

            if (battleSceneStatus.BattleTime >= 0) return;
            EndOfPlayback.QuitGame();
        }
    }
}
