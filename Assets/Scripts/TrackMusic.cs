using UnityEngine;

public class TrackMusic : MonoBehaviour
{
    public GameObject prefabMusic;
    void Start()
    {
        var music = GameObject.Find("BGM");
        if (music == null)
        {
            var tempMusic = Instantiate(prefabMusic, null);
            tempMusic.name = "BGM";
            DontDestroyOnLoad(tempMusic);
        }
    }


}
