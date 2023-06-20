using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace SceneManagement
{  
    public class SceneFadeIn : MonoBehaviour
    {
        [SerializeField] private Image fadeImage;
        [SerializeField] private float fadeDuration = 1f;
        private ObjectActivation objectActivation;

        private void Start()
        {
            if (fadeImage.gameObject.activeSelf)
            {
                fadeImage.gameObject.SetActive(false);

            }

            objectActivation = GetComponent<ObjectActivation>();

            StartCoroutine(TransitionSequence());
        }

        private IEnumerator TransitionSequence()
        {
            
            yield return StartCoroutine(FadeIn());
            objectActivation.Activation();
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

