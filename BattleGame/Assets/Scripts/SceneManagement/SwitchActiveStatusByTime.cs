using System.Collections;
using UnityEngine;


namespace SceneManagement
{
    public class SwitchActiveStatusByTime : MonoBehaviour
    {
        [SerializeField] private GameObject[] obj;
        [SerializeField] private float timeToSwitch;

        private void Start()
        {
            StartCoroutine(SwitchActive());
        }

        private IEnumerator SwitchActive()
        {
            yield return new WaitForSeconds(timeToSwitch);

            foreach (var item in obj)
            {
                item.SetActive(!item.activeSelf);
            }
        }
    }
}
