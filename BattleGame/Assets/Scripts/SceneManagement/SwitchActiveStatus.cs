using UnityEngine;


namespace SceneManagement
{
    public class SwitchActiveStatus : MonoBehaviour
    {
        [SerializeField] private GameObject[] obj; 

        public void OnButtonClick()
        {
            foreach (var item in obj)
            {
                item.SetActive(!item.activeSelf);
            }
        }
    }
}
