using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace SceneManagement
{  
    public class SceneFadeIn : MonoBehaviour
    {
        [SerializeField] private float fadeDuration;
        private ObjectActivation objectActivation;

        public void Starter(Image fadeImage)
        {
            Reference();

            StartCoroutine(TransitionSequence(fadeImage));
        }

        private IEnumerator TransitionSequence(Image fadeImage)
        {
            yield return StartCoroutine(FadeIn(fadeImage));
            objectActivation.Activation();
        }

        private IEnumerator FadeIn(Image fadeImage)
        {

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

        private void Reference()
        {
            objectActivation = GetComponent<ObjectActivation>();
        }
    }
}

