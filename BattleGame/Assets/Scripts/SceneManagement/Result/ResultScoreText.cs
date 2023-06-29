using SceneManagement.Result;
using SceneManagement.UI;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class ResultScoreText : MonoBehaviour
{
    private TextMeshProUGUI TextUI;
    private ResultAttribute resultAttribute;

    private void Start()
    {
        GetReference();
    }

    private void Text()
    {
        killScore = resultAttribute.KillCountAtEnd;
        Time = resultAttribute.RemainingTimeAtEnd;
        PlayerStamina = resultAttribute.
    }

    private IEnumerator ViewScores()
    {
        TextUI.text = ;
    }

    private void GetReference()
    {
        TextUI = GetComponent<TextMeshProUGUI>();
        resultAttribute = new ResultAttribute();
    }
}
