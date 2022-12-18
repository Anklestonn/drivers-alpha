using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn
    public float spawnIntervalMin = 1.0f; // Minimum interval between spawn
    public float spawnIntervalMax = 3.0f; // Maximum interval between spawn
    public float speed = 1.0f; // Speed of the spawned object

    // Start is called before the first frame update
    void Start()
    {
        // Start the spawn coroutine
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true) // Loop indefinitely
        {
            // Generate a random interval between spawnIntervalMin and spawnIntervalMax
            float spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);

            // Wait for the random interval before spawning the object
            yield return new WaitForSeconds(spawnInterval);

            // Spawn the object at the position and rotation of this GameObject
            GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.rotation);

            // Set the speed of the spawned object
            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;
        }
    }
}
