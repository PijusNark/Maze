using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Left/Right movement
        float vertical = Input.GetAxis("Vertical"); // Forward/Backward movement
        float upward = Input.GetAxis("Jump"); // Upward movement (usually mapped to Space bar)
        float downward = Input.GetKey(KeyCode.LeftControl) ? -1 : 0; // Downward movement (hold Left Control to go down)

        
        Vector3 direction = new Vector3(horizontal, upward + downward, vertical).normalized;

        
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
