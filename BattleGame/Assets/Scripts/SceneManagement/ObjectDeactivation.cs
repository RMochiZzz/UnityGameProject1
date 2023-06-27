using Interface;
using UnityEngine;

namespace SceneManagement
{
    public class ObjectDeactivation : MonoBehaviour, IActivation<GameObject[]>
    {
        public void Starter(GameObject[] objectsToDeactivate)
        {
            Deactivation(objectsToDeactivate);
        }

        private void Deactivation(GameObject[] objectsToDeactivate)
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
        }
    }
}
