using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float moveSpeed = 5;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//sa� ya da sola bas�ld��� zaman yap�lacaklar�n tan�m�.
        float vertical = Input.GetAxis("Vertical");//yukar� ya da a�a�� bas�ld��� zaman yap�lacaklar�n tan�m�.

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement *Time.deltaTime * moveSpeed;


    }
}
