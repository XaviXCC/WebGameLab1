using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    public GameObject escMenu;
    

    public void Resume()
    {
       
        escMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
