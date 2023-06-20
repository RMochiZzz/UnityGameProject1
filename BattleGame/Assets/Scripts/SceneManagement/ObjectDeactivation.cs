using UnityEngine;

namespace SceneManagement
{
    public class ObjectDeactivation : MonoBehaviour
    {
        [SerializeField] private GameObject[] objectsToDeactivate;
        public void Deactivation()
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
        }
    }
}
