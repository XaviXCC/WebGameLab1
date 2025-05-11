using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Time.timeScale = 0f;
            GameObject canvas = GameObject.Find("Canvas");
            canvas.transform.Find("Lose").gameObject.SetActive(true);
        }
 
    }
}
