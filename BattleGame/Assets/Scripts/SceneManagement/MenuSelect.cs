using UnityEngine;
using UnityEngine.SceneManagement;


namespace SceneManagement
{
    public class MenuSelect : MonoBehaviour
    {
        public static void SwitchMenu()
        {
            SceneManager.LoadScene("MenuScene");
        }

        public static void SwitchBattle()
        {
            SceneManager.LoadScene("BattleScene");
        }

        public static void ExitGame()
        {
            EndOfPlayback.QuitGame();
        }

    }

}

