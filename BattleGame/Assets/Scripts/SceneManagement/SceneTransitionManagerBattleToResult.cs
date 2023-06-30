using Core.Character.Player;
using SceneManagement.Battle;
using UnityEngine;
using System.Collections;
using Interface;

namespace SceneManagement
{
    public class SceneTransitionManagerBattleToResult : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject sceneManager;
        [SerializeField] private GameObject[] objectsToDeactivate;
        [SerializeField] private GameObject[] objectsToActivate1;
        [SerializeField] private GameObject[] objectsToActivate2;
        [SerializeField] private GameObject[] objectsToActivate3;
        [SerializeField] private float interval;

        private PlayerAttribute playerAttribute;
        private BattleSceneStatus battleSceneStatus;
        private IActivation<GameObject[]> objectDeactivation;
        private IActivation<GameObject[]> objectActivation;

        private void Start()
        {
            GetReference();
        }

        private void Update()
        {
            switch (playerAttribute.CurrentPlayerStamina * battleSceneStatus.RemainingTime)
            {
                case 0:
                    StartCoroutine(TransitionSequence());
                    break;
            }
        }

        private IEnumerator TransitionSequence()
        {
            objectDeactivation.Starter(objectsToDeactivate);
            yield return new WaitForSeconds(interval);

            objectActivation.Starter(objectsToActivate1);
            yield return new WaitForSeconds(interval);

            objectActivation.Starter(objectsToActivate2);
            yield return new WaitForSeconds(interval);

            objectActivation.Starter(objectsToActivate3);
            yield return new WaitForSeconds(interval);

            yield return null;
        }

        private void GetReference()
        {
            playerAttribute = player.GetComponent<PlayerAttribute>();
            battleSceneStatus = sceneManager.GetComponent<BattleSceneStatus>();
            objectDeactivation = GetComponent<ObjectDeactivation>();
            objectActivation = GetComponent<ObjectActivation>();
        }
    }

}
