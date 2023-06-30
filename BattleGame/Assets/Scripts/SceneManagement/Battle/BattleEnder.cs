using Core.Character.Player;
using SceneManagement.Battle;
using UnityEngine;

public class BattleEnder : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject battleSceneManager;

    private PlayerAttribute playerAttribute;
    private BattleSceneStatus battleSceneStatus;
    private ResultScoreText resultScoreText;
    private void Start()
    {
        GetReference();
    }
    private void Update()
    {
        switch (playerAttribute.CurrentPlayerStamina * battleSceneStatus.RemainingTime)
        {
            case 0:

                break;
        }
    }

    private void GetReference()
    {
        playerAttribute = player.GetComponent<PlayerAttribute>();
        battleSceneStatus = battleSceneManager.GetComponent<BattleSceneStatus>();
    }

}
