using System.Collections;
using TMPro;
using UnityEngine;

namespace SceneManagement.Result
{
    public class ResultScoreText : MonoBehaviour
    {
        private TextMeshProUGUI TextComp;
        private ResultAttribute resultAttribute;

        public void Start()
        {
            GetReference();

            StartCoroutine(ViewScores());
        }

        private IEnumerator ViewScores()
        {
            TextComp.text = "Kill Count: " + resultAttribute.KillCountAtEnd.ToString() + "\n" +
                    "Remaining Time: " + resultAttribute.RemainingTimeAtEnd.ToString() + "\n" +
                    "Player Stamina: " + resultAttribute.PlayerStaminaAtEnd.ToString();

            yield return null;
        }

        private void GetReference()
        {
            TextComp = GetComponent<TextMeshProUGUI>();
            resultAttribute = new ResultAttribute();
        }
    }
}
