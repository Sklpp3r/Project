using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform targetPoint;
    public float moveSpeed = 2f;
    private bool hasArrived = false;

    void Update()
    {
        if (!hasArrived)
        {

            transform.position =
                Vector3.MoveTowards(transform.position, targetPoint.position, moveSpeed * Time.deltaTime);


            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                hasArrived = true;
            }
        }
    }

    public bool HasArrived()
    {
        return hasArrived;
    }

    public void ChangeTarget(Transform newTarget)
    {
        targetPoint = newTarget;
        hasArrived = false;
    }
}
