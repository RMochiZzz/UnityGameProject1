using UnityEngine;
using UnityEngine.UI;

public class CanvasAspectRatioAdjuster : MonoBehaviour
{
    private float targetAspectRatio = 16f / 9f;

    private CanvasScaler canvasScaler;

    private void Awake()
    {
        canvasScaler = GetComponent<CanvasScaler>();
        AdjustCanvasScale();
    }

    private void Update()
    {
        if (Screen.width != canvasScaler.referenceResolution.x || Screen.height != canvasScaler.referenceResolution.y)
        {
            AdjustCanvasScale();
        }
    }

    private void AdjustCanvasScale()
    {
        float currentAspectRatio = (float)Screen.width / Screen.height;
        float scale = currentAspectRatio / targetAspectRatio;

        if (scale < 1f)
        {
            canvasScaler.matchWidthOrHeight = 0f;
            canvasScaler.referenceResolution = new Vector2(Screen.width / scale, Screen.height);
        }
        else
        {
            canvasScaler.matchWidthOrHeight = 1f;
            canvasScaler.referenceResolution = new Vector2(Screen.width, Screen.height * scale);
        }
    }
}