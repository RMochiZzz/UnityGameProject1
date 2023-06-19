using UnityEngine;

namespace Core.Character.Enemy
{
    public class UnFollowParent : MonoBehaviour
    {
        [SerializeField] private string parent;

        private void Start()
        {
            transform.SetParent(null);

            GameObject parentObject = GameObject.Find(parent);
            Transform parentTransform = parentObject.transform;
            transform.SetParent(parentTransform);

        }
    }
}
