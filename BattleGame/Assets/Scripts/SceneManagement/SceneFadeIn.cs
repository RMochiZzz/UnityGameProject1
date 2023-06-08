using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace SceneManagement
{  
    public class SceneFadeIn : MonoBehaviour
    {
        public Image fadeImage;
        public float fadeDuration = 1f;

        private void Start()
        {
            fadeImage.gameObject.SetActive(false);

            StartCoroutine(TransitionSequence());
        }

        private IEnumerator TransitionSequence()
        {
            
            yield return StartCoroutine(FadeIn());
            ObjectAllActivation.Activation();
        }

        private IEnumerator FadeIn()
        {
            fadeImage.gameObject.SetActive(true);

            float t = 0f;
            Color startColor = Color.black;
            Color endColor = Color.clear;

            while (t < 1f)
            {
                t += Time.unscaledDeltaTime / fadeDuration;
                fadeImage.color = Color.Lerp(startColor, endColor, t);
                yield return null;
            }
        }
    }
}

