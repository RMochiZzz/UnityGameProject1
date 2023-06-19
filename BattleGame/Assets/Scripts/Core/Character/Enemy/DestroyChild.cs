using UnityEngine;

public class DestroyChild : MonoBehaviour
{
    [SerializeField]private GameObject child;

    private void OnDestroy()
    {
        Destroy(child);
    }
}
