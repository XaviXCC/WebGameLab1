using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitGame()
    {
        // quit game
        Application.Quit();

        // quit Unity Editor 
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}