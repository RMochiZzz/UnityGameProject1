using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Interface;

namespace SceneManagement
{  
    public class SceneFadeIn : MonoBehaviour, ISceneFade<Image, float>
    {

        public void Starter(Image fadeImage, float fadeDuration)
        {
            StartCoroutine(FadeIn(fadeImage, fadeDuration));
        }

        private IEnumerator FadeIn(Image fadeImage, float fadeDuration)
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
    }
}

