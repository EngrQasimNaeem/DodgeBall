using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;

    public GameObject blockPrefab;
    private float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
        
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoint.Length);

        for (int i = 0; i < spawnPoint.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoint[i].position,
                Quaternion.identity);
            }
        }
    }
}
