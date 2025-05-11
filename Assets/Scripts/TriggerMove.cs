using UnityEngine;

public class TriggerMove : MonoBehaviour
{
    private bool islift =  false;
    private void OnTriggerEnter(Collider other)
    {
        islift = true;
    }

    private void Update()
    {
        if (!islift)
        {
            return;
        }
        else
        {
            gameObject.transform.parent.transform.Translate(0, 10 * Time.deltaTime, 0);
        }
    }
}
