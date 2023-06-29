using SceneManagement.Result;
using System.Collections;
using TMPro;
using UnityEngine;

public class ResultScoreText : MonoBehaviour
{
    private TextMeshProUGUI TextComp;
    private ResultAttribute resultAttribute;
    private int killScore;
    private float Time;
    private int PlayerStamina;

    private void Start()
    {
        GetReference();
    }

    private void Text()
    {
        killScore = resultAttribute.KillCountAtEnd;
        Time = resultAttribute.RemainingTimeAtEnd;
        PlayerStamina = resultAttribute.PlayerStaminaAtEnd;
    }

    private IEnumerator ViewScores()
    {
        TextUI.text = killScore;
    }

    private void GetReference()
    {
        TextUI = GetComponent<TextMeshProUGUI>();
        resultAttribute = new ResultAttribute();
    }
}
