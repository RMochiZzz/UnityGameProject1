using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace SceneManagement
{
    public class ExitFadeOut : MonoBehaviour
    {
        [SerializeField] private Image fadeImage;
        [SerializeField] private float timeForDarkening;

        void Start()
        {
            Init();
        }

        private void Init()
        {
            if (!fadeImage.gameObject.activeSelf) return;

            fadeImage.gameObject.SetActive(false);

        }
        public void OnButtonClick()

        {
            StartCoroutine(FadeOut());
        }

        private IEnumerator FadeOut()
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

            MenuSelect.ExitGame();
        }
    }

}
