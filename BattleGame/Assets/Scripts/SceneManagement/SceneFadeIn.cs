using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Interface;

namespace SceneManagement
{  
    public class SceneFadeIn : MonoBehaviour, ISceneFade<Image, float>
    {
        private float elapsedTime;

        public void Starter(Image fadeImage, float fadeDuration)
        {
            StartCoroutine(FadeIn(fadeImage, fadeDuration));
        }

        private IEnumerator FadeIn(Image fadeImage, float fadeDuration)
        {

            float startTime = Time.realtimeSinceStartup;
            elapsedTime = 0f;
            Color startColor = Color.black;
            Color endColor = Color.clear;

            while (elapsedTime < 1f)
            {
                elapsedTime = Time.realtimeSinceStartup - startTime;
                fadeImage.color = Color.Lerp(startColor, endColor, elapsedTime);
                yield return null;
            }

            fadeImage.gameObject.SetActive(false);
        }
    }
}

