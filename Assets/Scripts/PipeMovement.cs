using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 3.5f;
    public float endPipe = -70f;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < endPipe)
        {
            Destroy(gameObject);
        }
    }
}
