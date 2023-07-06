using UnityEngine;

[ExecuteAlways]
public class AspectRatioController : MonoBehaviour
{
    public float targetAspectRatio = 16f / 9f;

    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
        UpdateAspectRatio();
    }

    private void Update()
    {
        UpdateAspectRatio();
    }

    private void UpdateAspectRatio()
    {
        float currentAspectRatio = (float)Screen.width / Screen.height;

        float scaleHeight = currentAspectRatio / targetAspectRatio;
        Rect rect = cam.rect;

        if (scaleHeight < 1f)
        {
            rect.width = 1f;
            rect.height = scaleHeight;
            rect.x = 0f;
            rect.y = (1f - scaleHeight) / 2f;
        }
        else
        {
            float scaleWidth = 1f / scaleHeight;
            rect.width = scaleWidth;
            rect.height = 1f;
            rect.x = (1f - scaleWidth) / 2f;
            rect.y = 0f;
        }

        cam.rect = rect;
    }
}
