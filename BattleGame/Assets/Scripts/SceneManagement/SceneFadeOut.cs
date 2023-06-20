using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace SceneManagement
{
    public class SceneFadeOut : MonoBehaviour
    {
        [SerializeField] private Image fadeImage;
        [SerializeField] private float fadeDuration;
        private ObjectDeactivation objectDeactivation;
        private SceneFadeIn sceneFadeIn;
        private void Start()
        {
            objectDeactivation = GetComponent<ObjectDeactivation>();
            sceneFadeIn = GetComponent<SceneFadeIn>();
        }
        public void OnButtonClick()
        {
            StartCoroutine(TransitionSequence());
        }

        private IEnumerator TransitionSequence()
        {

            yield return StartCoroutine(FadeOut());
            objectDeactivation.Deactivation();
            sceneFadeIn.Starter(fadeImage);
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