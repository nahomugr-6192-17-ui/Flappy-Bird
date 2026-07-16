using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float jumpVelocity = 5f;
    public Rigidbody2D rb;
    public logicScript logic;
    public bool birdIsAlive = true;
    public bool hasGameStarted = false;
    public AudioSource audioSource;
    public AudioClip jumpSound;

    public void Start()
    {
        rb.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (!hasGameStarted)
            {
                StartGame();
            }
            else if (birdIsAlive)
            {
                rb.linearVelocityY = jumpVelocity;
                audioSource.PlayOneShot(jumpSound);
            }
        }
        if (rb.transform.position.y < -27f || rb.transform.position.y > 27f)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

    public void StartGame()
    {
        if (hasGameStarted)
            return;

        hasGameStarted = true;

        rb.simulated = true;   // Enable gravity

        logic.StartGame();     // Hide the UI

        rb.linearVelocityY = jumpVelocity;   // First flap

        audioSource.PlayOneShot(jumpSound);
    }
}
