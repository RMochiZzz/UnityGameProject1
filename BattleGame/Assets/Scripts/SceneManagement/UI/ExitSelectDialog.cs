using UnityEngine;


namespace SceneManagement.UI
{
    public class ExitSelectDialog : MonoBehaviour
    {
        [SerializeField] private GameObject dialog; 

        public void OnButtonClick()
        {
            dialog.SetActive(!dialog.activeSelf);
        }
    }

}
