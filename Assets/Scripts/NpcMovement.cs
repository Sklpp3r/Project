using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform targetPoint;
    public float moveSpeed = 2f;
    private bool hasArrived = false;
    public GameObject cubePrefab;
    public Transform cubeSpawnPoint;
    private GameObject spawnedCube;
    public GameObject infoCanvas;

    void Update()
    {
        /*
        if (!hasArrived)
        {

            transform.position =
                Vector3.MoveTowards(transform.position, targetPoint.position, moveSpeed * Time.deltaTime);


            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                hasArrived = true;
                SpawnCube();
            }
        }
        if (hasArrived && Vector3.Distance(transform.position, targetPoint.position) > 1f)
        {
            DestroySpawnedObjects();
            hasArrived = false; 
        }
    }

    public bool HasArrived()
    {
        return hasArrived;
    }

    public void ChangeTarget(Transform newTarget)
    {
        if (hasArrived == false)
        {
            return;
        }
        targetPoint = newTarget;
        hasArrived = false;
    }
    void SpawnCube()
    {
        spawnedCube = Instantiate(cubePrefab, cubeSpawnPoint.position, Quaternion.identity);
    }
    void DestroySpawnedObjects()
    {
        if (spawnedCube != null)
        {
            Destroy(spawnedCube); 
        }

        if (infoCanvas != null)
        {
            infoCanvas.SetActive(false); 
        }
    }
    */
    }
}