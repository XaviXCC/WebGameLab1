using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private GameObject canvas;
    private GameObject player;
 
    void Start()
    {
        player = GameObject.Find("Player");
        canvas = GameObject.Find("Canvas");
        canvas.transform.Find("Win").gameObject.SetActive(false);
        canvas.transform.Find("Lose").gameObject.SetActive(false);
    }

    
    void Update()
    {
        CheckPlayerFall();
        GameReplay();
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        canvas.transform.Find("Win").gameObject.SetActive(true);
    }

    public void CheckPlayerFall()
    {
        if (player != null && player.transform.position.y < -10)
        {
            Time.timeScale = 0;
            canvas.transform.Find("Lose").gameObject.SetActive(true);
        }
    }

    public void GameReplay()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
}
