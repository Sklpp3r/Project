using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public List<GameObject> npcPrefabs; 
    public Transform spawnPoint; 
    public Transform targetPoint; 
    public float spawnDelay = 2f; 
    private bool isSpawning = false; 
    private GameObject lastSpawnedNPC;
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

        
        GameObject selectedNPC = GetRandomNPC();

       
        GameObject newNPC = Instantiate(selectedNPC, spawnPoint.position, Quaternion.identity);
        NPCMovement npcMovement = newNPC.GetComponent<NPCMovement>();
        npcMovement.targetPoint = targetPoint;
        newNPC.tag = "NPC"; 

        lastSpawnedNPC = selectedNPC; 
        isSpawning = false; 
    }

    GameObject GetRandomNPC()
    {
        if (npcPrefabs.Count < 2) return npcPrefabs[0]; 
        GameObject selectedNPC;
        do
        {
            selectedNPC = npcPrefabs[Random.Range(0, npcPrefabs.Count)];
        } while (selectedNPC == lastSpawnedNPC); 

        return selectedNPC;
    }
    }

   

