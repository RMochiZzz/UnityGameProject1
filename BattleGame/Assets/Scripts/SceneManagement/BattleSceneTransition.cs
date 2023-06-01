using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace SceneManagement
{
    public class BattleSceneTransition : MonoBehaviour
    {
        public Image fadeImage;
        public float timeForDarkening = 1f;

        void Start()
        {
            fadeImage.gameObject.SetActive(false);
        }

        public void OnButtonClick()
        {
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()
        {
            fadeImage.gameObject.SetActive(true);

            float elapsedTime = 0f;
            Color startColor = Color.clear;
            Color endColor = Color.black;

            while (elapsedTime < timeForDarkening)
            {
                float t = elapsedTime / timeForDarkening;
                fadeImage.color = Color.Lerp(startColor, endColor, t);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            fadeImage.color = endColor;

            MenuSelect.SwitchBattle();
        }
    }

}
