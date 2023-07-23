using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    private GameManager gameManager;
    public float spawnRate = 2.0f;
    private float timer = 0;
    public float heightOffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        SpawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameOver == false)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;

            }
            else
            {
                SpawnPipes();
                timer = 0;
            }
        }
          
    }

    void SpawnPipes()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 randomYPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),transform.position.z);
        Instantiate(pipes, randomYPosition, pipes.transform.rotation);
    }

    

    
}
