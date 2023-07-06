using UnityEngine;

public class ObjectResize : MonoBehaviour
{
    private Camera cameraComponent;
    private Transform objTransform;
    private Vector3 initialObjScale;

    private void Start()
    {
        objTransform = transform;
        cameraComponent = Camera.main;
        initialObjScale = objTransform.localScale;
    }

    private void Update()
    {
        if (Screen.width != cameraComponent.pixelWidth || Screen.height != cameraComponent.pixelHeight)
        {
            ResizeObject();
        }
    }

    private void ResizeObject()
    {
        float cameraSize = cameraComponent.orthographicSize;
        float targetSize = 4f;

        objTransform.localScale = initialObjScale * (cameraSize / targetSize);
    }
}
