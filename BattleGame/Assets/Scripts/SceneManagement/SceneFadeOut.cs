using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Interface;

namespace SceneManagement
{
    public class SceneFadeOut : MonoBehaviour, ISceneFade<Image, float>
    {
        private float elapsedTime;

        public void Starter(Image fadeImage, float fadeDuration)
        {
            StartCoroutine(FadeOut(fadeImage, fadeDuration));
        }

        private IEnumerator FadeOut(Image fadeImage, float fadeDuration)
        {
            fadeImage.gameObject.SetActive(true);

            float startTime = Time.realtimeSinceStartup;
            elapsedTime = 0f;
            Color startColor = Color.clear;
            Color endColor = Color.black;

            while (elapsedTime < fadeDuration)
            {
                elapsedTime = Time.realtimeSinceStartup - startTime;
                fadeImage.color = Color.Lerp(startColor, endColor, elapsedTime);
                yield return null;
            }
        }
    }
}
