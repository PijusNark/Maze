using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Left/Right 
        float vertical = Input.GetAxis("Vertical"); // Forward
        float upward = Input.GetAxis("Jump"); // Up
        float downward = Input.GetKey(KeyCode.LeftControl) ? -1 : 0; // Downward (cntrl)

        
        Vector3 direction = new Vector3(horizontal, upward + downward, vertical).normalized;

        
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
