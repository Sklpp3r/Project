using UnityEngine;

public class CubeClickHandler : MonoBehaviour
{
    
    public Transform alternateTarget;

    void OnMouseDown()
    {
      
        GameObject npc = GameObject.FindGameObjectWithTag("NPC"); 
        if (npc != null)
        {
            if (npc.TryGetComponent<NPCMovement>(out var npcMovement))
            {
              //  npcMovement.ChangeTarget(alternateTarget);
            }
        }
    }
}
