using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject escMenu;
    public GameObject dieMenu;
 

    private void Start()
    {
        
        escMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !dieMenu.activeInHierarchy)
        {
            if (!escMenu.activeInHierarchy)
            {
                Time.timeScale = 0;
                escMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;

            }
            else
            {
                Time.timeScale = 1;
                escMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
          
        
    }
}
