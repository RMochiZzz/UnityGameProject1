using System;
using UnityEngine;
using TMPro;

namespace SceneManager.UI
{
    public class TimeText : MonoBehaviour
    {
        private TextMeshProUGUI timerText;

        private void Start()
        {
            timerText = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            BattleSceneAttribute.battleTime -= Time.deltaTime;
            TimeSpan span = new TimeSpan(0, 0, (int)BattleSceneAttribute.battleTime);
            timerText.text = span.ToString(@"mm\:ss");

            if (BattleSceneAttribute.battleTime >= 0) return;
            EndOfPlayback.QuitGame();
        }


    }
}
