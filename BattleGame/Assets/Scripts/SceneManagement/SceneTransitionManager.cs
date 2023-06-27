using SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneTransitionManager : MonoBehaviour
{
    [SerializeField] private Image fadeImage;
    [SerializeField] private float fadeDuration;

    private ObjectDeactivation objectDeactivation;
    private ObjectActivation objectActivation;
    private SceneFadeIn sceneFadeIn;
    private SceneFadeOut sceneFadeOut;

    public void OnButtonClick()
    {
        GetReference();
        StartCoroutine(TransitionSequence());
    }

    private IEnumerator TransitionSequence()
    {
        sceneFadeOut.Starter(fadeImage, fadeDuration);
        yield return new WaitForSeconds(fadeDuration);
        objectDeactivation.Deactivation();
        yield return null;
        objectActivation.Activation();
        yield return null;
        sceneFadeIn.Starter(fadeImage, fadeDuration);
    }


    private void GetReference()
    {
        objectDeactivation = GetComponent<ObjectDeactivation>();
        objectActivation = GetComponent<ObjectActivation>();
        sceneFadeIn = GetComponent<SceneFadeIn>();
        sceneFadeOut = GetComponent<SceneFadeOut>();
    }
}
