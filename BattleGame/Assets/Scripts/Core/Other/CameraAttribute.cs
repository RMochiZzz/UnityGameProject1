using UnityEngine;

namespace Core.Other 
{
    public static class CameraAttribute
    {
        public static float cameraHeight = 2f * Camera.main.orthographicSize;
        public static float cameraWidth = cameraHeight * Camera.main.aspect;
    }
}
