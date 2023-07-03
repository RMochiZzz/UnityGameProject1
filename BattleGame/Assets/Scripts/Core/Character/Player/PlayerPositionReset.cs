using UnityEngine;

public class PlayerPositionReset : MonoBehaviour
{
    private void OnEnable()
    {
        transform.position = Vector3.zero;
    }
}
