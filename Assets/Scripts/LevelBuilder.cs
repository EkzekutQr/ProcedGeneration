using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField]
    List<GameObject> chunks = new List<GameObject>();

    [SerializeField]
    List<GameObject> spawnedChunks = new List<GameObject>();

    [SerializeField]
    Transform player;

    private void Start()
    {

        chunks.AddRange(GameObject.FindGameObjectsWithTag("Chunk"));

        spawnedChunks.Add(GameObject.FindGameObjectWithTag("StartChunk"));

    }
    private void FixedUpdate()
    {
        BuildChunk();
    }
    private void BuildChunk()
    {
        if(player.position.x >= spawnedChunks[spawnedChunks.Count - 1].transform.position.x - 10)
        {
            GameObject newChunk = Instantiate(chunks[Random.Range(0, chunks.Count)]);

            GameObject oldChunk = spawnedChunks[spawnedChunks.Count - 1];

            spawnedChunks.Add(newChunk);

            newChunk.transform.position = oldChunk.GetComponent<ChunkScript>().End.position - newChunk.GetComponent<ChunkScript>().Begin.localPosition;

            if(spawnedChunks.Count > 5)
            {
                Destroy(spawnedChunks[0].gameObject);
                spawnedChunks.RemoveAt(0);
            }
        }
    }
}
