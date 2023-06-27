using UnityEngine;

namespace SceneManagement
{
    public class ObjectActivation : MonoBehaviour
    {
        public void Activation(GameObject[] objectsToActivate)
        {
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}
