using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace SceneManagement
{
    public class SceneTransition : MonoBehaviour
    {
        public Image fadeImage;
        public float fadeDuration = 1f;
        public string scene;
        private void Start()
        {
            fadeImage.gameObject.SetActive(false);
        }
        public void OnButtonClick()
        {
            StartCoroutine(TransitionSequence());
        }

        private IEnumerator TransitionSequence()
        {
            yield return StartCoroutine(FadeOut());

            SceneManager.LoadScene(scene);
        }

        private IEnumerator FadeOut()
        {
            fadeImage.gameObject.SetActive(true);

            float t = 0f;
            Color startColor = Color.clear;
            Color endColor = Color.black;

            while (t < 1f)
            {
                t += Time.deltaTime / fadeDuration;
                fadeImage.color = Color.Lerp(startColor, endColor, t);
                yield return null;
            }
        }
    }
}