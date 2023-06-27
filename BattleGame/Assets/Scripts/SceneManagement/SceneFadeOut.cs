using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace SceneManagement
{
    public class SceneFadeOut : MonoBehaviour
    {

        public void Starter(Image fadeImage, float fadeDuration)
        {
            StartCoroutine(FadeOut(fadeImage, fadeDuration));
        }

        private IEnumerator FadeOut(Image fadeImage, float fadeDuration)
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
