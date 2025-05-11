using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float shiftSpeed = 1f;
    void Update()
    {
        gameObject.transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        CheckShift();
        CheckPlayerOutofTrack(); 
    }


    private void CheckShift()
    {
        float shiftVariables = Input.GetAxis("Horizontal");
        gameObject.transform.Translate( 0 ,0, shiftVariables * shiftSpeed *  Time.deltaTime );
    }

    private void CheckPlayerOutofTrack()
    {
        if(gameObject.transform.position.z < -4 || gameObject.transform.position.z > 4)
        {
            transform.Translate(0, -20 * Time.deltaTime, 0);
        }
    }
}
