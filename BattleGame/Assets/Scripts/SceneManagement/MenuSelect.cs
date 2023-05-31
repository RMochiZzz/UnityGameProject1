using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
}
