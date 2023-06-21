using System;
using UnityEngine;
using TMPro;
using SceneManagement.Battle;

namespace SceneManagement.UI
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
            TimeSpan span = new TimeSpan(0, 0, (int)battleSceneStatus.BattleTime);
            timerText.text = span.ToString(@"mm\:ss");
        }
    }
}
