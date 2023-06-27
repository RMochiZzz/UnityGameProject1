using Interface;
using UnityEngine;

namespace SceneManagement
{
    public class ObjectActivation : MonoBehaviour, IActivation<GameObject[]>
    {
        public void Starter(GameObject[] objectsToDeactivate)
        {
            Activation(objectsToDeactivate);
        }

        private void Activation(GameObject[] objectsToActivate)
        {
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}
