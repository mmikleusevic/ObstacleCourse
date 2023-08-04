using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Ideš naprijed nazad ljevo desno debilu \n" +
            "Jebo ga iss");
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 inputVector = new Vector3(horizontalInput, 0, verticalInput);

        if (inputVector.sqrMagnitude > 1) inputVector.Normalize();

        Vector3 movement = inputVector * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
