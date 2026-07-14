using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float jumpVelocity = 5f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            rb.linearVelocityY = jumpVelocity;
        }
    }
}
