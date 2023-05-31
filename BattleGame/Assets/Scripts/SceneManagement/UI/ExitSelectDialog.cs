using UnityEngine;


namespace SceneManagement.UI
{
    public class ExitSelectDialog : MonoBehaviour
    {
        public GameObject dialog; 

        public void OnButtonClick()
        {
            dialog.SetActive(!dialog.activeSelf);
        }
    }

}
