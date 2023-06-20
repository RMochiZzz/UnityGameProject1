using UnityEngine;

namespace SceneManagement
{
    public class ObjectActivation : MonoBehaviour
    {
        [SerializeField] private GameObject[] objectsToActivate;
        public void Activation()
        {
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}
