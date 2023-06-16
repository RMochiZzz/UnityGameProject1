using UnityEngine;

namespace Core.Control
{
    public class UnFollowParent : MonoBehaviour
    {
        private void Start()
        {
            transform.parent = null;
        }
    }
}
