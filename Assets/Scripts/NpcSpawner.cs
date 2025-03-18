using System.Collections;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public GameObject npcPrefab; 
    public Transform spawnPoint; 
    public Transform targetPoint; 
    
    public float spawnDelay = 2f; 

    private bool isSpawning = false; 

    private GameObject currentNPC;

   
    void Update()
    {
        
        if (GameObject.FindGameObjectWithTag("NPC") == null && !isSpawning)
        {
            StartCoroutine(SpawnNPCWithDelay());
        }
    }

    IEnumerator SpawnNPCWithDelay()
    {
        isSpawning = true;
        yield return new WaitForSeconds(spawnDelay); 

        
        GameObject newNPC = Instantiate(npcPrefab, spawnPoint.position, Quaternion.identity);
        NPCMovement npcMovement = newNPC.GetComponent<NPCMovement>();
        npcMovement.targetPoint = targetPoint;
        newNPC.tag = "NPC"; 

        isSpawning = false; 
    }

   
}
