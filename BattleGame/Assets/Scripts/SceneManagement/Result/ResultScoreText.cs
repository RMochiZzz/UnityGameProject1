using SceneManagement.Result;
using System.Collections;
using TMPro;
using UnityEngine;

public class ResultScoreText : MonoBehaviour
{
    private TextMeshProUGUI TextComp;
    private ResultAttribute resultAttribute;

    private void Starter()
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
