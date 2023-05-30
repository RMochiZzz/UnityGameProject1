using UnityEngine;

namespace SceneManager
{
    public class EndOfPlayback : MonoBehaviour
    {
        public static void QuitGame()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }

}