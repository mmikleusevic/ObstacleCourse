using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    string objTag = "Player";
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == objTag)
        {
            GetComponent<MeshRenderer>().material.color = Color.magenta;
            gameObject.tag = "Hit";
        }
    }
}
