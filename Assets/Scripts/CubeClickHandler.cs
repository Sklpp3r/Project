using UnityEngine;

public class CubeClickHandler : MonoBehaviour
{
    
    public Transform alternateTarget;

    void OnMouseDown()
    {
      
        GameObject npc = GameObject.FindGameObjectWithTag("NPC"); 
        if (npc != null)
        {
            NPCMovement npcMovement = npc.GetComponent<NPCMovement>();
            if (npcMovement != null)
            {
                npcMovement.ChangeTarget(alternateTarget);
            }
        }
    }
}
