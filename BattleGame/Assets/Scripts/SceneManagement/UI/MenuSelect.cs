using UnityEngine;
using UnityEngine.SceneManagement;


namespace SceneManagement.UI
{
    public class MenuSelect : MonoBehaviour
    {
        public void SwitchBattle()
        {
            SceneManager.LoadScene("BattleScene");
        }

        public void ExitGame()
        {
            EndOfPlayback.QuitGame();
        }

    }

}

