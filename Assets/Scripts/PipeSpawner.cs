using System.Numerics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 2;
    private float timer = 0;
    public float heightOffset = 10f;

    void Start()
    {
        PipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            PipeSpawn();
            timer = 0f;
        }
    }

    void PipeSpawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float upperPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new (transform.position.x, Random.Range(lowestPoint, upperPoint), 0), transform.rotation);
    }
}
