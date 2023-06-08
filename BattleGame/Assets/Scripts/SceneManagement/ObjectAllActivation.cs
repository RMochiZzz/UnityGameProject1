using UnityEngine;

namespace SceneManagement
{
    public class ObjectAllActivation : MonoBehaviour
    {
        public static GameObject[] gameObjects;
        public static void Activation()
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.SetActive(true);
            }
        }
    }
}