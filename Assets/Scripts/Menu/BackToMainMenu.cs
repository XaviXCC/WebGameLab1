using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
}
