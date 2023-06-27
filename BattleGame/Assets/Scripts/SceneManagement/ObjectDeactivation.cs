using UnityEngine;

namespace SceneManagement
{
    public class ObjectDeactivation : MonoBehaviour
    {
        public void Deactivation(GameObject[] objectsToDeactivate)
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
        }
    }
}
