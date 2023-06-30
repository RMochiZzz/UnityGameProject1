using Core.Character.Player;
using SceneManagement.Battle;
using UnityEngine;
using System.Collections;
using Interface;
using SceneManagement.Result;

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

        private bool isTransition;

        private PlayerAttribute playerAttribute;
        private BattleSceneStatus battleSceneStatus;
        private ResultDataGatherer resultDataGatherer;
        private IActivation<GameObject[]> objectDeactivation;
        private IActivation<GameObject[]> objectActivation;

        private void Start()
        {
            Init();
            GetReference();
        }

        private void Update()
        {
            if (isTransition) return;
            TransitionStarter();
        }

        private void TransitionStarter()
        {
            switch (playerAttribute.CurrentPlayerStamina * battleSceneStatus.RemainingTime)
            {
                case 0:
                    StartCoroutine(TransitionSequence());
                    isTransition = true;
                    break;
            }
        }

        private IEnumerator TransitionSequence()
        {
            resultDataGatherer.Starter();

            objectDeactivation.Starter(objectsToDeactivate);
            yield return new WaitForSeconds(interval);

            objectActivation.Starter(objectsToActivate1);
            objectActivation.Starter(objectsToActivate2);
            yield return new WaitForSeconds(interval);

            objectActivation.Starter(objectsToActivate3);
            yield return new WaitForSeconds(interval);

            yield return null;
        }

        private void Init()
        {
            isTransition = false;
        }

        private void GetReference()
        {
            resultDataGatherer = GetComponent<ResultDataGatherer>();
            playerAttribute = player.GetComponent<PlayerAttribute>();
            battleSceneStatus = sceneManager.GetComponent<BattleSceneStatus>();
            objectDeactivation = GetComponent<ObjectDeactivation>();
            objectActivation = GetComponent<ObjectActivation>();
        }
    }

}
