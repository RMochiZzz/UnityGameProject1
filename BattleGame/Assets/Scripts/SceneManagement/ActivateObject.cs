using UnityEngine;

namespace SceneManagement
{
    public class ActivateObject : MonoBehaviour
    {
        public GameObject[] objectsToActivate;
        private void Start()
        {
            ObjectAllActivation.gameObjects = objectsToActivate;
        }
    }

}
