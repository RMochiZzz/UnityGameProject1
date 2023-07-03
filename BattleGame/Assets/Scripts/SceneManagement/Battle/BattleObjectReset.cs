using UnityEngine;

namespace SceneManagement.Battle
{
    public class BattleObjectReset : MonoBehaviour
    {

        [SerializeField] private GameObject player;
        [SerializeField] private GameObject sceneManager;
        [SerializeField] private GameObject[] containers;

        public void Starter()
        {
            DestroyObjects();
        }

        private void DestroyObjects()
        {
            foreach (GameObject container in containers)
            {
                foreach (Transform child in container.transform)
                {
                    Destroy(child.gameObject);
                }
            }
        }
    }
}
