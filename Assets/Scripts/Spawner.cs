using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> prefabs = new List<GameObject>();
    public Vector3 target;
    public float startSpeed = 1;
    public float maxSpeed = 10;

    void Start()
    {
        // Invoke the Spawn method every second
        InvokeRepeating("Spawn", 1, 1);
    }

    void Spawn()
    {
        // Generate a random number between 0 and 2
        int randomIndex = Random.Range(0, prefabs.Count);

        // Get the prefab at the randomly generated index
        GameObject prefab = prefabs[randomIndex];

        // Spawn the prefab at the spawner's position
        GameObject spawnedObject = Instantiate(prefab, transform.position, Quaternion.identity);

        // Move the spawned object towards the target
        StartCoroutine(MoveTowardsTarget(spawnedObject));
    }

    IEnumerator MoveTowardsTarget(GameObject spawnedObject)
    {
        // Set the initial speed of the object
        float speed = startSpeed;

        while (true)
        {
            // Get the current position of the spawned object
            Vector3 currentPosition = spawnedObject.transform.position;

            // Gradually increase the speed of the object
            speed = Mathf.Lerp(speed, maxSpeed, Time.deltaTime);

            // Calculate a new position that is closer to the target
            Vector3 newPosition = Vector3.MoveTowards(currentPosition, target, speed * Time.deltaTime);

            // Set the spawned object's position to the new position
            spawnedObject.transform.position = newPosition;

            // Stop the loop if the object has reached the target
            if (newPosition == target)
            {
                Destroy(spawnedObject);
                break;
                
            }

            yield return null;
        }
    }
}
