using Core.Character.Player;
using SceneManagement.Battle;
using UnityEngine;

namespace SceneManagement
{
    public class BattleObjectReset : MonoBehaviour
    {

        [SerializeField] private GameObject player;
        [SerializeField] private GameObject sceneManager;
        [SerializeField] private GameObject[] containers;

        private PlayerAttribute playerAttribute;
        private BattleSceneStatus battleSceneStatus;
        public void Starter()
        {
            GetReference();

            switch (playerAttribute.CurrentPlayerStamina * (int)battleSceneStatus.RemainingTime)
            {
                case 0:
                    DestroyObjects();
                    break;
            }
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

        private void GetReference()
        {
            playerAttribute = player.GetComponent<PlayerAttribute>();
            battleSceneStatus = sceneManager.GetComponent<BattleSceneStatus>();
        }
    }
}
