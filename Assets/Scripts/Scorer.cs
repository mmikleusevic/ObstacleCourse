using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCounter = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hitCounter++;
            Debug.Log($"You have bumped into something {hitCounter} times");
        }
    }
}
